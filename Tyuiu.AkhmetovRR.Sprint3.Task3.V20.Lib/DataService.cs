using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AkhmetovRR.Sprint3.Task3.V20.Lib
{
    public class DataService : ISprint3Task3V20
    {
        public int GetCharCount(string value, char item)
        {
            throw new NotImplementedException();
        }

        public double GetProductSeries(string text)
        {
            int count = 0;
            foreach (var item in text)
            {
                if (item == 'f')
                {
                    count++;
                }
            }
            return count;
        }

        public double GetProductSeries(string v, object text)
        {
            throw new NotImplementedException();
        }
    }
}
