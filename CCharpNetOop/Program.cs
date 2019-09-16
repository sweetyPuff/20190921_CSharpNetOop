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

			dynamic d = "d";
			d += 1;
			d += "123";
			Console.WriteLine(d);

			Console.ReadLine();
		}
	}
}