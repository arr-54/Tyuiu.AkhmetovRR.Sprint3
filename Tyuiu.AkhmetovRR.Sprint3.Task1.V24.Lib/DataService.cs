using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AkhmetovRR.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 0;
            int i = startValue;
            while (i <= stopValue)
            {

                result += Math.Pow(2 / (6 + Math.Pow(value, i)), i);
                i++;
            }
            return Math.Round(result, 3);
        }

        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}
