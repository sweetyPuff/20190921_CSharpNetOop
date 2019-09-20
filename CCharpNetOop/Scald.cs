using System;

namespace CCharpNetOop
{
	public class Scald
	{
		public void HandleBurn()
		{
			Rinse();
			Off();
			Dip();
			Cover();
			Send();
		}

		protected virtual void Rinse()
		{

			Console.WriteLine("水龍頭沖水");
		}

		protected virtual void Off()
		{
			Console.WriteLine("脫去衣物");
		}

		protected virtual void Dip()
		{
			Console.WriteLine("泡在水中");
		}

		protected virtual void Cover()
		{
			Console.WriteLine("蓋上乾淨毛巾");
		}

		protected virtual void Send()
		{
			Console.WriteLine("快點送醫");
		}
	}
}