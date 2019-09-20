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
			return false;
		}
	}
}