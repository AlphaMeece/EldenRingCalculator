namespace EldenRingCalculator.Classes
{
	public static class ToolBox
	{
		public static int Scaling(int stat, int currentCap, int previousCap, double exp, int baseValue, int maxValue, int scale = 1)
		{
			if (exp > 0)
			{
				return (int)(baseValue*scale + (maxValue*scale - baseValue*scale) * Math.Pow(((double)stat - previousCap) / (currentCap - previousCap), exp));
			}
			return (int)(baseValue*scale + (maxValue*scale - baseValue*scale) * (1 - Math.Pow(1 - ((double)stat - previousCap) / (currentCap - previousCap), -1 * exp)));
		}
	}
}
