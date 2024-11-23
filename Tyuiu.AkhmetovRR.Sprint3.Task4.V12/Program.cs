using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint3.Task4.V12.Lib;

namespace Tyuiu.AkhmetovRR.Sprint3.Task4.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага =" + startValue);
            Console.WriteLine("Конец шага =" + stopValue);

            Console.WriteLine("Произведение ряда = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}