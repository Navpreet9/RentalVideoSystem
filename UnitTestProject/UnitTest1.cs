using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RentalVideoSystem;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Database Obj_DB = new Database();

        [TestMethod]
        public void TestMethod1()
        {
            bool data_Return = Obj_DB.AddRentedMovie("8", "100", DateTime.Today);
            Assert.AreEqual(true, data_Return);
        }
        [TestMethod]
        public void TestMethod2()
        {
            bool data_Return = Obj_DB.AddRentedMovie("15", "10", DateTime.Today);
            Assert.AreEqual(true, data_Return);
        }
    }
}
