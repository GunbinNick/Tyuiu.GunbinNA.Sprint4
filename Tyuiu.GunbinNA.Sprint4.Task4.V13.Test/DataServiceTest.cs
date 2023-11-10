using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint4.Task4.V13.Lib;
namespace Tyuiu.GunbinNA.Sprint4.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = { { 6, 3, 5, 7, 5 }, 
                             { 3, 5, 7, 4, 5 }, 
                             { 5, 6, 4, 5, 4 }, 
                             { 7, 4, 7, 3, 3 }, 
                             { 4, 6, 5, 5, 6 } };
            int wait = 44;
            var res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
