using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalsagovUA.Sprint2.Task5.V12.Lib;
namespace Tyuiu.MalsagovUA.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g = 2005;
            int m = 5;
            int n = 28;
            double res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = "2005526";
            Assert.AreEqual(wait, res);
        }
    }
}
