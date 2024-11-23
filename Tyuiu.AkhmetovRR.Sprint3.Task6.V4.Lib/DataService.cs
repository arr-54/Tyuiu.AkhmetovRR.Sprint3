using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AkhmetovRR.Sprint3.Task6.V4.Lib
{
    public class DataService : ISprint3Task6V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                valueArray[count] = Calculate(x);
                count++;
            }
            return valueArray;
        }
        public double Calculate(int x)
        {
            double drob = 2 * x - 0.5;
            if (drob == 0)
            {
                return 0;
            }
            double result = 5 - 3 * x + ((1 + Math.Sin(x)) / drob);
            return Math.Round(result, 2);
        }

        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}
