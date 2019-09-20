using System;

namespace CCharpNetOop
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var authenticationService = new AuthenticationService();
			var isValid = authenticationService.Verify("Kyo", "1qaz2wsx", "0880449");
			Console.WriteLine("Verify result:" + isValid);
		}
	}
}