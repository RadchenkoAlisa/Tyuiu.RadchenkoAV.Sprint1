using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RadchenkoAV.Sprint1.Task7.V30.Lib;
namespace Tyuiu.RadchenkoAV.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.7;
            double y = 2.1;
            double wait = 9.478;

            double result = ds.Calculate(x, y);

            Assert.AreEqual(wait, result);
        }
    }
}