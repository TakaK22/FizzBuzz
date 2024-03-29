using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [DataTestMethod]
        [DataRow("1", 1)]
        [DataRow("2", 2)]
        public void TestMethod1(string expected, int number)
        {
            string actual = FizzBuzz1.Convert(number);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("Fizz", 3)]
        [DataRow("Fizz", 6)]
        public void TestMethod2(string expected, int number)
        {
            string actual = FizzBuzz1.Convert(number);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("Buzz", 5)]
        [DataRow("Buzz", 10)]
        public void TestMethod3(string expected, int number)
        {
            string actual = FizzBuzz1.Convert(number);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("FizzBuzz", 15)]
        [DataRow("FizzBuzz", 30)]
        public void TestMethod4(string expected, int number)
        {
            string actual = FizzBuzz1.Convert(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
