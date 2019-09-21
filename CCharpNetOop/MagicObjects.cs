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
			Console.WriteLine(a.Equals(b)); // 使用int的Equals, 但object的.Equals是比對記憶體位置的

		}

		public void MagicObject()
		{
			object a = "a";
			object b = "a"; // compile time 會做String最佳化 (run time不會做string最佳化), 指到同一個記憶體位置

			Console.WriteLine(nameof(MagicObject));
			Console.WriteLine(a == b);
			Console.WriteLine(a.Equals(b)); // 使用string的Equals, 兩個都是比對記憶體位置

		}

		public void MagicObject(string s)
		{
			object a = s;
			object b = s;
			a += "a"; // 各自產生新的記憶體位置
			b += "a"; // 各自產生新的記憶體位置 += 的運算時是run time, 不會做string 最佳化

            Console.WriteLine(nameof(MagicObject)+nameof(s));
			Console.WriteLine(a == b); // 判斷記憶體位置是否相同
			Console.WriteLine(a.Equals(b)); // 判斷value是否相同

		}
	}
}