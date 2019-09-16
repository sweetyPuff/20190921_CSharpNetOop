using System;

namespace CCharpNetOop
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("object:");
			var mo = new MagicObjects();

			mo.MagicObject();
			mo.MagicObject(1);
			mo.MagicObject("a");

			Console.WriteLine();
			Console.WriteLine("dynamic:");
			dynamic d = "d";
			d += 1;
			d += "123";
			Console.WriteLine(d);

			Console.WriteLine();
			Console.WriteLine("string:");
			var a= new MyStringClass {StringName = "Hello"};
			var b = a;
			b.StringName = "World";

			Console.WriteLine(a.StringName);
			Console.WriteLine(b.StringName);

			string strA = "hello";
			string strB = strA;
			strB = "world";
			Console.WriteLine(strA);
			Console.WriteLine(strB);

			Console.ReadLine();
		}
	}

	internal class MyStringClass
	{
		public string StringName { get; set; }
	}
}