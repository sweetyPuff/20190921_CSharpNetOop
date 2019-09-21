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
			Console.WriteLine("dynamic:"); //不檢查型別, 一切都在run time決定 compile時感覺一片祥和
			dynamic d = "d";
			d += 1;
			d += "123";
			Console.WriteLine(d);

			Console.WriteLine();
			Console.WriteLine("string:");
			var a= new MyStringClass {StringName = "Hello"};
			var b = a;
			b.StringName = "World"; // b是ref到a, 把b裡面的string name property改掉了, 但a/b都是指到同一個instance, 所以一起被改掉了 

			Console.WriteLine(a.StringName);
			Console.WriteLine(b.StringName);

			string strA = "hello";
			string strB = strA;
			strB = "world";
            string cccc = new string('a', 3);
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