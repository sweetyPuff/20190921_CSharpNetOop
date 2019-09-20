using Dapper;
using SlackAPI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace CCharpNetOop
{
	internal class AuthenticationService
	{
		public bool Verify(string accountId, string password, string otp)
		{
var httpClient = new HttpClient() { BaseAddress = new Uri("http://joey.dev/") };

			var accountLockedResponse = httpClient.PostAsJsonAsync("api/failedCounts/status", accountId).Result;
			if (accountLockedResponse.IsSuccessStatusCode)
			{
				if (accountLockedResponse.Content.ReadAsAsync<bool>().Result)
				{
					throw new AccountLockedException() { Id = accountId };
				}
			}
			else
			{
				throw new Exception($"web api error, accountId:{accountId}");
			}

			string passwordFromDb;
			using (var connection = new SqlConnection("my connection string"))
			{
				passwordFromDb = connection.Query<string>(
					"sp_GetUserPassword",
					new { Id = accountId },
					commandType: CommandType.StoredProcedure).SingleOrDefault();
			}

			var crypt = new System.Security.Cryptography.SHA256Managed();
			var hash = new StringBuilder();
			var crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password));
			foreach (var theByte in crypto)
			{
				hash.Append(theByte.ToString("x2"));
			}

			var hashedPassword = hash.ToString();

			var otpResponse = httpClient.PostAsJsonAsync("api/otps", accountId).Result;

			string currentOtp;
			if (otpResponse.IsSuccessStatusCode)
			{
				currentOtp = otpResponse.Content.ReadAsAsync<string>().Result;
			}
			else
			{
				throw new Exception($"web api error, accountId:{accountId}");
			}

			if (hashedPassword == passwordFromDb && otp == currentOtp)
			{
				var resetResponse = httpClient.PostAsJsonAsync("api/failedCounts/Rest", accountId);
				resetResponse.Result.EnsureSuccessStatusCode();

				return true;
			}
			else
			{
				var failedCountAddResponse = httpClient.PostAsJsonAsync("api/failedCounts/Add", accountId).Result;
				failedCountAddResponse.EnsureSuccessStatusCode();

				var failedCountResponse = httpClient.PostAsJsonAsync("api/failedCounts/Get", accountId).Result;
				failedCountResponse.EnsureSuccessStatusCode();

				int failedCount = failedCountResponse.Content.ReadAsAsync<int>().Result;

				var logger = NLog.LogManager.GetCurrentClassLogger();
				logger.Info($"{accountId} verify failed. failed count is {failedCount}");

				var slackClient = new SlackClient("my api token");
				slackClient.PostMessage(x => { }, "my channel", "my message", "my bot name");

				return false;
			}
		}
	}
}