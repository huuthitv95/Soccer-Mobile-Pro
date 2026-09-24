namespace Common
{
	public class DoubleUS
	{
		public static double Parse(string s)
		{
			return 0.0;
		}

		public static bool TryParse(string s, out double result)
		{
			result = default;
			return false;
		}
	}
}
