using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint2.Task6.V14.Lib;

namespace Tyuiu.FrezeTK.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFindDayOfWeekValid()
        {
            Assert.AreEqual("понедельник", DataService.FindDayOfWeek(1, 1));
            Assert.AreEqual("вторник", DataService.FindDayOfWeek(1, 2));
            Assert.AreEqual("воскресенье", DataService.FindDayOfWeek(2, 6));
        }
    }
}
