using System;
using FizzBuzzer;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void Test_with_Default_input([Values(1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19)] int input)
        {
            string output = FizzBuzz.GetNumber(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Test_Fizz([Values(3, 6, 9, 12, 18)] int input)
        { 
            string output = FizzBuzz.GetNumber(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Test_Buzz([Values(5, 10, 20)] int input)
        {
            string output = FizzBuzz.GetNumber(input);
            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void Test_FizzBuzz([Values(15)] int input)
        {
            string output = FizzBuzz.GetNumber(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
