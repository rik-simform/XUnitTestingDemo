using System;
using System.Collections.Generic;
using System.Text;
using XUnitConsole;
using Xunit;

namespace XUnit.Test
{
    public class CalculatorTest
    {
      
        [Fact]
        public void Addition_ShouldCalculateSimpleValues()
        {
            
            double expected = 9;

            double actual = Calculator.Addition(3, 6);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 6, 9)]
        [InlineData(4, 3, 7)]
        [InlineData(-10, 10, 0)]
        [InlineData(34, 5.33, 39.33)]
        [InlineData(-10, -10, -20)]
        public void Addition_ShouldCalculateSimpleValues1(double num1, double num2, double expected)
        {
            //arrange+act
            double actual = Calculator.Addition(num1, num2);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]
        [InlineData(-9, 3, -3)]
        [InlineData(15, 0, 0)]
        public void Division_ShouldCalculateSimpleValues(double num1, double num2, double expected)
        {
            //arrange+act
            double actual = Calculator.Division(num1, num2);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Division_ShouldDivideByZero()
        {
            //arrange
            double expected = 0;

            // act
            double actual = Calculator.Division(15, 0);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtraction_ShouldCalculateSimpleValues()
        {

            double expected = 3;

            double actual = Calculator.Subtraction(6,3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6 , 3, 3)]
        [InlineData(4, 3, 2)]
        [InlineData(-10, 10, 0)]
        [InlineData(34, 5.33, 28.67)]
        [InlineData(-10, -10, -20)]
        public void Subtraction_ShouldCalculateSimpleValues1(double num1, double num2, double expected)
        {
            //arrange+act
            double actual = Calculator.Subtraction(num1, num2);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiplication_ShouldCalculateSimpleValues()
        {

            double expected = 18;

            double actual = Calculator.Multiplication(6, 3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 3, 18)]
        [InlineData(4, 3, 12)]
        [InlineData(-10, 10, -100)]
        [InlineData(34, 5.33, 181.22)]
        [InlineData(-10, -10, 100)]
        public void Multiplication_ShouldCalculateSimpleValues1(double num1, double num2, double expected)
        {
            //arrange+act
            double actual = Calculator.Multiplication(num1, num2);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
