using System;
using MathFunctions;
using Xunit;

namespace Tests
{
    public class MathFunctionsTests
    {
        [Fact]
        public void TestFib10()
        {
         //Arrange
         var expected = 55;
         //Act
         var result = Fibonacci.FibonacciVal(10);   
         //Assert
         Assert.True(expected == result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void FactorialTestLowInts(int value)
        {
            //Arrange 
            var expected = (value == 2)? 2 : 1;
            //Act
            var result = Factorial.FBigInt(value);
            //Assert
            Assert.True(result==expected);
        }
    }
}
