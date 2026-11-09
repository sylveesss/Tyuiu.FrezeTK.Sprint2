using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FrezeTK.Sprint2.Task4.V28.Lib;

namespace Tyuiu.FrezeTK.Sprint2.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid1()
        {

            double x = 2;
            double y = 10;
            double expected = 16.0;

            double res = DataService.Calculate(x, y);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void CheckCalculateValid2()
        {
            double x = 10;
            double y = 5;
            double expected = 6.273; 

            double res = DataService.Calculate(x, y);
            Assert.AreEqual(expected, res);
        }
    }
}
