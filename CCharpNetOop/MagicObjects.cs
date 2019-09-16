using System;

namespace CCharpNetOop
{
	internal class MagicObjects
	{
		public void MagicObject(int i)
		{
			object a = i;
			object b = i;

			Console.WriteLine(nameof(MagicObject)+nameof(i));
			Console.WriteLine(a == b);
			Console.WriteLine(a.Equals(b));

		}

		public void MagicObject()
		{
			object a = "a";
			object b = "a";

			Console.WriteLine(nameof(MagicObject));
			Console.WriteLine(a == b);
			Console.WriteLine(a.Equals(b));

		}

		public void MagicObject(string s)
		{
			object a = s;
			object b = s;
			a += "a";
			b += "a";

			Console.WriteLine(nameof(MagicObject)+nameof(s));
			Console.WriteLine(a == b);
			Console.WriteLine(a.Equals(b));

		}
	}
}