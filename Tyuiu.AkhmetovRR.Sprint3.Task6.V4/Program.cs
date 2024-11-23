using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint3.Task6.V4.Lib;

namespace Tyuiu.AkhmetovRR.Sprint3.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(14, 20);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
