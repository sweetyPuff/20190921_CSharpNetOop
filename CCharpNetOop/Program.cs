using System;

namespace CCharpNetOop
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var mo = new MagicObjects();
			mo.MagicObject();
			mo.MagicObject(1);
			mo.MagicObject("a");
			Console.ReadLine();
		}
	}
}