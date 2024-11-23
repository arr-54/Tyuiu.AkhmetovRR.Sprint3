using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint3.Task7.V26.Lib;

namespace Tyuiu.AkhmetovRR.Sprint3.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine(" Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(valueArray[i]);
                startValue++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
