namespace CCharpNetOop
{
	public class ScaldFactory
	{
		public static Scald GetScald(string type)
		{
			Scald kyoScald;
			if (type=="Kyo")
			{
				kyoScald = new KyoScald();
			}
			else
			{
				kyoScald = new Scald();
			}
			return kyoScald;
		}
	}
}