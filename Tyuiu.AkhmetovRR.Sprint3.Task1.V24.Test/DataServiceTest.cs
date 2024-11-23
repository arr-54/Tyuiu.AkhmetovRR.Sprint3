using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint3.Task1.V24.Lib;

namespace Tyuiu.AkhmetovRR.Sprint3.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;

            int stopValue = 3;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = Math.Pow(2 / (6 + Math.Pow(value, 1)), 1) + Math.Pow(2 / (6 + Math.Pow(value, 2)), 2) + Math.Pow(2 / (6 + Math.Pow(value, 3)), 3);
            Assert.AreEqual(res, Math.Round(wait, 3));
        }
    }
}
