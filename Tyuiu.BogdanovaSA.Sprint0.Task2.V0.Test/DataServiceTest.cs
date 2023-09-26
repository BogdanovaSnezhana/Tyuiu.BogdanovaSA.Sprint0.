using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BogdanovaSA.Sprint0.Task2.V0.Lib;
using System; 

namespace Tyuiu.BogdanovaSA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest

    {
        [TestMethod]
        public void ChekGetMessageValid()

        {
            var name = "Снежана";
            var res = DataService.GetMessage(name);


            Assert.AreEqual("Привет, Снежана", res);
        }
    }
}
