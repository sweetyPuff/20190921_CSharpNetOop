using System;

namespace CCharpNetOop
{
	internal class AccountLockedException : Exception
	{
		public string Id { get; set; }
	}
}