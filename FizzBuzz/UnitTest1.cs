using NUnit.Framework;

namespace Tests
{
    public class FizzBuzzTests
    {
        public object FizzBuzz(int number)
        {
            if (number % 15 == 0)
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number;
        }

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Given1Expect1()
        {
            var expected = 1;
            var actual = FizzBuzz(1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given2Expect2()
        {
            var expected = 2;
            var actual = FizzBuzz(2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given3ExpectFizz()
        {
            var expected = "Fizz";
            var actual = FizzBuzz(3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Given5ExpectBuzz()
        {
            var expected = "Buzz";
            var actual = FizzBuzz(5);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Given6ExpectFizz()
        {
            var expected = "Fizz";
            var actual = FizzBuzz(6);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Given15ExpectFizzBuzz()
        {
            var expected = "FizzBuzz";
            var actual = FizzBuzz(30);
            Assert.AreEqual(expected, actual);
        }
    }
}