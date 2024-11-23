using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint3.Task2.V26.Lib;

namespace Tyuiu.AkhmetovRR.Sprint3.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetProductSeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 2;

            double res = ds.GetProductSeries(value, startValue, stopValue);

            double wait = ((Math.Pow(value, 3) * 1) + 2) * ((Math.Pow(value, 3) * 2 + 2));

            Assert.AreEqual(res, wait, 1e-10);
        }
    }
}
