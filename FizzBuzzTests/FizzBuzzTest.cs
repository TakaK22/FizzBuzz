using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string actual = FizzBuzz1.Convert(1);
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
    }
}
