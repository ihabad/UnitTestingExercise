using System;
using Xunit;
using Xunit.Sdk;


namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------

        public void Add(int num1, int num2, int num3, int expected)

        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            var test = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actually = test.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);

            Assert.Equal(expected, actually);
        }

        [Theory]
        [InlineData(8, 4, 4)]//Add test data <-------

        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var Secondtest = new Calculator();

            //Act

            var actually = Secondtest.subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actually);
        }

        [Theory]
        [InlineData(3, 3, 9)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var ThirdTest = new Calculator();

            //Act

            var actually = ThirdTest.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actually);
        }

        [Theory]
        [InlineData(8, 2, 4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var DivideTest = new Calculator();
            //Act

            var actually = DivideTest.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actually);
        }

    }
}
