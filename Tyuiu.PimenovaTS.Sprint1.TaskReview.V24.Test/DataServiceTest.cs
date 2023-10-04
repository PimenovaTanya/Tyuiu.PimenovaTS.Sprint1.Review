using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint1.TaskReview.V24.Lib;

namespace Tyuiu.PimenovaTS.Sprint1.TaskReview.V24.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 0;
            double z = 0.771;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}
