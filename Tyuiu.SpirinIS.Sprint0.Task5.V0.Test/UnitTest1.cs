using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DatskiyDE.Sprint0.Task5.V0.Lib;

namespace Tyuiu.DatskiyDE.Sprint0.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Substraction(10, 5));
        }
        [TestMethod]

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));

        }
        [TestMethod]
        public void CheckedDivionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
