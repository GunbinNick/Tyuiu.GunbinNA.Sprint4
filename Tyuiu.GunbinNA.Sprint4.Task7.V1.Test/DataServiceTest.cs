using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint4.Task7.V1.Lib;
namespace Tyuiu.GunbinNA.Sprint4.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "135792468";
            int wait = 4;
            int n = 3;
            int m = 3;
            var res = ds.Calculate(n, m, str);
            Assert.AreEqual(wait, res);
        }
    }
}
