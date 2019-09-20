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
			// step1. use accountId query password from db by dapper
			// step2. use httpClient get current Otp from api
			// step3. hash password
			// step4. compare hashed password with password with db && otp with current Otp from api
			return false;
		}
	}
}