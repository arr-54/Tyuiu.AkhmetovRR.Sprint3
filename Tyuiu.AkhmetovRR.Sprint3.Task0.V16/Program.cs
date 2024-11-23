using System;
using Tyuiu.AkhmetovRR.Sprint3.Task0.V16.Lib;

namespace Tyuiu.AkhmetovRR.Sprint3.Task0.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue = 1;
            int stopValue = 6;
            Console.WriteLine(" Переменная x = " + x);
            Console.WriteLine(" Старт шага = " + startValue);
            Console.WriteLine(" Конец шага " + stopValue);
            Console.WriteLine(" Произведение ряда: " + ds.GetMultiplySeries(startValue, stopValue, x));
            Console.ReadKey();
        }
    }
}
