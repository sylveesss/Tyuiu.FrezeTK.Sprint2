using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FrezeTK.Sprint2.Task0.V8.Lib;

namespace Tyuiu.FrezeTK.Sprint2.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetCompareOperationsValid()
        {
            int x = 185;
            int y = 251;

            bool[] expected = new bool[] { true, false, true, false, true, false };
            bool[] res = DataService.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}
