using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint4.Task3.V2.Lib;
namespace Tyuiu.GunbinNA.Sprint4.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = { { 6, 4, 2, 2, 1 }, { 3, 6, 5, 4, 1 }, {5, 2, 3, 1, 6}, { 8, 8, 4, 5, 3}, { 7, 4, 5, 1, 6} };
            int wait = 13;
            var res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
