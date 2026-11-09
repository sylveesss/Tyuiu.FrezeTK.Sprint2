using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FrezeTK.Sprint2.Task3.V17.Lib;

namespace Tyuiu.FrezeTK.Sprint2.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
          
            double x = 0;
            double expected = -0.286;

            double res = DataService.Calculate(x);
            Assert.AreEqual(expected, res);
        }
    }
}
