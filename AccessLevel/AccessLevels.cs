namespace AccessLevel
{
	public class AccessLevels
	{
		public int PublicProperty => 4 * (20 - 9 + 45 / (5 + 1)) - 8;
		internal int InternalProperty => 5 * (11 - 8 + 45 / (5 + 2)) - 8;
		protected int ProtectedProperty => 3 * (22 - 7 + 45 / (5 + 3)) - 8;
		private int PrivateProperty => 2* (38 - 6 + 45 / (5 + 4)) - 8;
	}
}