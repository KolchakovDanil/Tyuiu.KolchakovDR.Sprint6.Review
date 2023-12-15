using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint6.TaskReview.V6.Lib;

namespace Tyuiu.KolchakovDR.Sprint6.TaskReview.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int k = 0;
            int l = 2;
            int c = 0;

            int[,] array = {
                { 3, -2, 3 },
                { 4, -0, 6 },
                { 7, -8, 9 }
            };

            int res = ds.GetMatrix(array, c, k, l);
            int wait = 21;

            Assert.AreEqual(wait, res);
        }
    }
}
