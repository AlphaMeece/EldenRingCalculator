namespace EldenRingCalculator.Classes
{
    public class StatScale
    {
        public int[] Points;
        public int[] Coefficients;
        public double[] Factors;

        public StatScale(int[] points, int[] coefficients, double[] factors)
        {
            Points = points;
            Coefficients = coefficients;
            Factors = factors;
        }
    }
}
