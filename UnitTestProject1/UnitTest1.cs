using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    public static class Generator
    {
        public static object FizzBuzz(int n)
        {
            if (n < 1)
            { 
                throw new IndexOutOfRangeException();
            }
            if (n % 5 == 0)
            {
                return "Buzz";
            }
            if (n == 3)
            {
                return "Fizz";
            }
            return n;
        }
    }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given1Expect1()
        {
            var expected = 1;
            var actual = Generator.FizzBuzz(1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Given2Expect2()
        {
            var expected = 2;
            var actual = Generator.FizzBuzz(2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Given3Expect3()
        {
            var expected = "Fizz";
            var actual = Generator.FizzBuzz(3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Given4Expect4()
        {
            var expected = 4;
            var actual = Generator.FizzBuzz(4);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Given5Expect5()
        {
            var expected = "Buzz";
            var actual = Generator.FizzBuzz(5);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Given0ExpectException()
        {
            Generator.FizzBuzz(0);
        }
    }
}
