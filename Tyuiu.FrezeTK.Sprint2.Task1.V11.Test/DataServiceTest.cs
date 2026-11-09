using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FrezeTK.Sprint2.Task1.V11.Lib;

namespace Tyuiu.FrezeTK.Sprint2.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetLogicOperationsValid()
        {
            int a = 145;
            int b = 156;
            int c = 142;
            int d = 117;

            bool[] expected = new bool[] { false, false, true, false, true, false };
            bool[] res = DataService.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}
