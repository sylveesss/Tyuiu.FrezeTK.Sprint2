using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FrezeTK.Sprint2.Task5.V8.Lib;

namespace Tyuiu.FrezeTK.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFindPreviousDateValid1()
        {

            Assert.AreEqual("09.08", DataService.FindPreviousDate(8, 10));
        }

        [TestMethod]
        public void CheckFindPreviousDateValid2()
        {
            Assert.AreEqual("30.04", DataService.FindPreviousDate(5, 1));
        }
    }
}
