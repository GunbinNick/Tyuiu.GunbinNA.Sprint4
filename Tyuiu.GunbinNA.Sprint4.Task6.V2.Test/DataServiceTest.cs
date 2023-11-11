using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint4.Task6.V2.Lib;
namespace Tyuiu.GunbinNA.Sprint4.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };
            string[] wait = { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" };
            var res = ds.Calculate(array);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
