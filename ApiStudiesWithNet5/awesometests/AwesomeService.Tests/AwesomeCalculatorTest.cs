using System;
using Xunit;

namespace AwesomeService.Tests
{
    public class AwesomeCalculator_Add_Should
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(3,2,1)]
        [InlineData(7,7,7)]
        [InlineData(34, 89, 32)]
        public void Return_Sum_Of_Values(int nr1, int nr2, int nr3)
        {
            ICalculator calculator = new AwesomeCalculator();
            var actualResult = calculator.Add(nr1, nr2, nr3);
            var expectedResult = nr1 + nr2 + nr3;
            Assert.Equal(expectedResult, actualResult);
        }
    }
}