using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MoskalevEA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MoskalevEA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckgetMessageValid()
        {
            var name = "Егор";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Егор", res);
        }
    }
}
