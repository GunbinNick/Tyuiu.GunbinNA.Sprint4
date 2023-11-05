using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint4.Task2.V15.Lib;

namespace Tyuiu.GunbinNA.Sprint4.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 8, 1, 4, 4, 1, 2, 3, 5, 1, 5, 9};
            int wait = 18;
            var res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
