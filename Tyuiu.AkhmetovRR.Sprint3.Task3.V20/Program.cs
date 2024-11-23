using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint3.Task3.V20.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.AkhmetovRR.Sprint3.Task3.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string text = "gfft ntf f opf";
            double result = ds.GetCharCount(text, 'f');
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

