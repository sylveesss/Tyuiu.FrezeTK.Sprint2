using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FrezeTK.Sprint2.Task2.V21.Lib;

namespace Tyuiu.FrezeTK.Sprint2.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaValid()
        {
            int x1 = 3;
            int y1 = 3;
            bool res1 = DataService.CheckDotInShadedArea(x1, y1);
            Assert.IsTrue(res1);
            int x2 = 1;
            int y2 = 1;
            bool res2 = DataService.CheckDotInShadedArea(x2, y2);
            Assert.IsFalse(res2);
        }
    }
}
