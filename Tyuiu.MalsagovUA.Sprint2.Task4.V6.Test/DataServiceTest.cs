using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalsagovUA.Sprint2.Task4.V6.Lib;
namespace Tyuiu.MalsagovUA.Sprint2.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 11;
            double res = ds.Calculate(x, y);
            double wait = 129;
            Assert.AreEqual(wait, res);
        }
    }
}
