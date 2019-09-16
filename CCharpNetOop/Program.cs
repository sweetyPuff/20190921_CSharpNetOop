using System;
using System.Reflection;
using AccessLevel;

namespace CCharpNetOop
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var accessLevel = new AccessLevels();
			Console.WriteLine(accessLevel.PublicProperty);
			Console.WriteLine(accessLevel.InternalProperty);

			var derivedAccessLevels = new DerivedAccessLevels();
			Console.WriteLine(derivedAccessLevels.GetProtectedProperty);

			var type = typeof(AccessLevels);
			var privateProperty = type.InvokeMember("PrivateProperty",
				BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Instance,
				null, accessLevel, new object[] { });

			Console.WriteLine(privateProperty);

			Console.ReadLine();
		}
	}

	internal class DerivedAccessLevels : AccessLevels
	{
		public int GetProtectedProperty => ProtectedProperty;
	}
}