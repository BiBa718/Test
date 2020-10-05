using System;
using Xunit;

namespace MathCalculatorTests
{
    public class MathCalculatorTest
    {
        private const int Ten = 10; 
        private const int Six = 6;
        private const int Five = 5;
        private const int Four = 4;
        private const int Three = 3;
        private const int Two = 2;
        private const int Zero = 0;       

        [Fact]
        public void WhenSumFiveAndThreeThenGotEight()
        {
            // Arrange
            MathCalculator calculator = new MathCalculator();     

            // Act
            var result = calculator.Sum(Five, Three);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void WhenSubFiveAndThreeThenGotTwo()
        {
            MathCalculator calculator = new MathCalculator();

            var result = calculator.Subtract(Five, Three);

            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenMultFiveAndThreeThenGotTwo()
        {
            MathCalculator calculator = new MathCalculator();

            var result = calculator.Multiply(Five, Three);

            Assert.Equal(15, result);
        }

        [Fact]
        public void WhenDivFiveAndThreeThenGotTwo()
        {
            MathCalculator calculator = new MathCalculator();

            var result = calculator.Divide(Five, Three);

            Assert.Equal(1, result);
        }
    }
}
