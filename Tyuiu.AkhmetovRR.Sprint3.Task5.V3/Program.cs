﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint3.Task5.V3.Lib;

namespace Tyuiu.AkhmetovRR.Sprint3.Task5.V3
{
    internal class Program
    {
        private static string stopValue1;

        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 11;

            Console.WriteLine("Переменная x =" + x);
            Console.WriteLine("Старт шага первой суммы ряда =" + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда =" + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда =" + startValue2);
            Console.WriteLine("Конец шага второй суммы ряда =" + stopValue2);

            Console.WriteLine("Сумма сумм ряда = " + ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2));
            Console.ReadKey();
        }
    }
}

