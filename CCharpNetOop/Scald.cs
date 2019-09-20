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

			Console.WriteLine("水龍頭沖水");
		}

		private void Off()
		{
			Console.WriteLine("脫去衣物");
		}

		private void Dip()
		{
			Console.WriteLine("泡在水中");
		}

		private void Cover()
		{
			Console.WriteLine("蓋上乾淨毛巾");
		}

		private void Send()
		{
			Console.WriteLine("快點送醫");
		}
	}
}