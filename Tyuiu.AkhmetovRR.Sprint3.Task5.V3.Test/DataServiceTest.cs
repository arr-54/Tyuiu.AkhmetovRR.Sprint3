using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint3.Task5.V3.Lib;

namespace Tyuiu.AkhmetovRR.Sprint3.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 1;
            int startValue2 = 1;
            int stopValue2 = 1;

            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);

            double wait = (Math.Sin(1) + x) / x;

            Assert.AreEqual(res, Math.Round(wait, 3));

        }
    }
}