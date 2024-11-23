using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AkhmetovRR.Sprint3.Task2.V26.Lib
{
    public class DataService : ISprint3Task2V26
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }

        public double GetProductSeries(double x, int i, int stopValue)
        {
            double res = 1;
            do
            {
                res *= (Math.Pow(x, 3) * i) + 2;
                i++;
            } while (i <= stopValue);
            return (res);
        }
    }
}
