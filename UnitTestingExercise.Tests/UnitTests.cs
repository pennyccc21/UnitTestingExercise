using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTestsMethods
    {
        [Theory]
        [InlineData(5,5,5,15)]
        public void add(int num1, int num2, int num3, int expected)
        {
            var test = new UnitTestsMethods();
            
            var actual = test.Add(num1, num2, num3);

            Assert.Equal(expected, actual);

        }

        private object Add(int num1, int num2, int num3)
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(5, 5, 0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            var tester = new UnitTestMethod();

            var actual = tester.Subtract(minuend, subtrhend);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(5, 4, 20)]
        public void Multiply(int num1, int num2, int expected)
        {
            var test = new UnitTestMethod();

            var actual = test.Multiply(num1, num2);

            Assert.Equal(expected, actual);

        }




        [Theory]
        [InlineData(20,5,40)] 
        public void DivideTest(int num1, int num2, int expected)
        {
            var tester = new UnitTestsMethods();

            var actual = tester.Divide(num1, num2);

            Assert.Equal(expected, actual);

        }

        private object Divide(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }

    internal class UnitTestMethod
    {
        public UnitTestMethod()
        {
        }

        internal object Multiply(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        internal object Subtract(int minuend, int subtrhend)
        {
            throw new NotImplementedException();
        }
    }
}
