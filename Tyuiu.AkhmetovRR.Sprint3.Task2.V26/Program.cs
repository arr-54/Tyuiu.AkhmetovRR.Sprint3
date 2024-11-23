using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint3.Task2.V26.Lib;

namespace Tyuiu.AkhmetovRR.Sprint3.Task2.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 17;

            Console.WriteLine("Переменная x " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("Произведение ряда = " + ds.GetProductSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}

