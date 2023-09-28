using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BogdanovaSA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.BogdanovaSA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(5, DataService.Addition(5, 5));
        }
        
        [TestMethod]
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(10, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(10, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheckDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
























    }   
}
