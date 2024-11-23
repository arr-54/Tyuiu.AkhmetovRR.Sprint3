using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AkhmetovRR.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }

        public double GetProductSeries(int startValue, int stopValue, double x)
        {
            double res = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                res *= Math.Pow((x / i), 3);
            }
            return (res);
        }
    }
}
