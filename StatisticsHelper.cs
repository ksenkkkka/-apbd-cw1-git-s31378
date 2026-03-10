public static class StatisticsHelper
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }
    
    public static double CalculateAverage(int[] values)
    {
        int sum = 0;

        foreach (int v in values)
        {
            sum += v;
        }

        return (double)sum / values.Length;
    }
}