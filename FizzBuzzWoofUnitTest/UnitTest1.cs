using FizzBuzzWoof;
using NUnit.Framework;

namespace FizzBuzzWoofUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //now I want to start testing to drive development
        //test for my first case
        [Test]
        public void PassInThreeReturnFizz()
        {
            // Arrange
            int input = 3;

            // Act
            string output = TestClass.FizzBuzzWoofMethod(input);

            // Assert that my values match
            Assert.AreEqual("Fizz", output);
        }

        //test for my first case
        [Test]
        public void PassInMultiplesThreeReturnFizz()
        {
            // Arrange
            int input = 9;

            // Act
            string output = TestClass.FizzBuzzWoofMethod(input);

            // Assert that my values match
            Assert.AreEqual("Fizz", output);
        }

        //move on to testing my next scenario
        [Test]
        public void PassInFiveReturnBuzz()
        {
            // Arrange
            int input = 5;

            // Act
            string output = TestClass.FizzBuzzWoofMethod(input);

            // Assert that my values match
            Assert.AreEqual("Buzz", output);
        }

        //move on to testing my next scenario
        [Test]
        public void PassInMultiplesOfFiveReturnBuzz()
        {
            // Arrange
            int input = 10;

            // Act
            string output = TestClass.FizzBuzzWoofMethod(input);

            // Assert that my values match
            Assert.AreEqual("Buzz", output);
        }

        //move on to testing my next scenario
        [Test]
        public void PassInSevenReturnWoof()
        {
            // Arrange
            int input = 7;

            // Act
            string output = TestClass.FizzBuzzWoofMethod(input);

            // Assert that my values match
            Assert.AreEqual("Woof", output);
        }

        //move on to testing my next scenario
        [Test]
        public void PassInMultiplesOfSevenReturnWoof()
        {
            // Arrange
            int input = 14;

            // Act
            string output = TestClass.FizzBuzzWoofMethod(input);

            // Assert that my values match
            Assert.AreEqual("Woof", output);
        }

        //write new test for first compund case
        [Test]//this attribute is needed for test framework to identify our test
        public void PassInFifteenReturnFizzBuzz()
        {
            //Arrange the variables you may need
            int input = 15;

            //Act on the method/methods to be tested
            string output = TestClass.FizzBuzzWoofMethod(input);

            //Assert that are test are passing
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}