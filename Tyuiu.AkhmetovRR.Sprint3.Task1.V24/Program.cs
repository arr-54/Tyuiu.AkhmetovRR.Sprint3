using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint3.Task1.V24.Lib;

namespace Tyuiu.AkhmetovRR.Sprint3.Task1.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 12;

            Console.WriteLine("Старт шага =" + startValue);
            Console.WriteLine("Конец шага =" + stopValue);

            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}

