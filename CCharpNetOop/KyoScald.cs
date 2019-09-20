using System;

namespace CCharpNetOop
{
	public class KyoScald:Scald
	{
		protected override void Rinse()
		{
			Console.WriteLine("買礦泉水沖洗");
		}

		protected override void Off()
		{
			Console.WriteLine("撕開衣物");
		}

		protected override void Dip()
		{
			Console.WriteLine("沒得泡");
		}

		protected override void Cover()
		{
			Console.WriteLine("蓋上撕開的衣物");
		}

		protected override void Send()
		{
			Console.WriteLine("叫小黃比較快!");
		}
	}
}