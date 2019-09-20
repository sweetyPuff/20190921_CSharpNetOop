using System;

namespace CCharpNetOop
{
	internal class Scald
	{
		public void HandleBurn()
		{
			Rinse();
			Off();
			Dip();
			Cover();
			Send();
		}

		private void Rinse()
		{

			Console.WriteLine("Rinse");
		}

		private void Off()
		{
			Console.WriteLine("Off");
		}

		private void Dip()
		{
			Console.WriteLine("Dip");
		}

		private void Cover()
		{
			Console.WriteLine("Cover");
		}

		private void Send()
		{
			Console.WriteLine("Send");
		}
	}
}