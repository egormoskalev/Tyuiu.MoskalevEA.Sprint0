using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MoskalevEA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.MoskalevEA.Sprint0.Task7.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            int[] num1 = new int[] { 1, 1, 1, 1, 1 };
            int[] num2 = new int[] { 1, 1, 1, 1, 1 };
            int[] num3 = new int[] { 2, 2, 2, 2, 2 };
            int[] res = DataService.AdditionArrays(num1, num2);
            CollectionAssert.AreEqual(num3, res);
        }
    }
}
