using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using Tyuiu.AkhmetovRR.Sprint3.Task6.V4.Lib;

namespace Tyuiu.AkhmetovRR.Sprint3.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 20;
            int y = 20;
            int z = 2;
            int result = ds.GetSumTheDivisors(x, y);
            Assert.AreEqual(z, result);
        }
    }
}
