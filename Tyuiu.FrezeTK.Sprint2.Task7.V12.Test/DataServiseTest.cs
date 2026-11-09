using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint2.Task7.V12.Lib;

namespace Tyuiu.FrezeTK.Sprint2.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaValid()
        {
            Assert.IsTrue(DataService.CheckDotInShadedArea(0.5, 0.2));
            Assert.IsFalse(DataService.CheckDotInShadedArea(1.5, 1.5));
        }
    }
}
