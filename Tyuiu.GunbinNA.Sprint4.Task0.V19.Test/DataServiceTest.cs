using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint4.Task0.V19.Lib;

namespace Tyuiu.GunbinNA.Sprint4.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int wait = 297675;
            var res = ds.GetMultOddArrEl(array);
            Assert.AreEqual(wait, res);
        }
    }
}
