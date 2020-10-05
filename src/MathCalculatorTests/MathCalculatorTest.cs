using System;
using Xunit;

namespace MathCalculatorTests
{
    public class MathCalculatorTest
    {
        private const int Five = 5;
        private const int Three = 3;     

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
        public void WhenSumMuniusFiveAndThreeThenGotMuniusTwo()
        {
            // Arrange(Подготовка данных)
            MathCalculator calculator = new MathCalculator();

            // Act
            int results = calculator.Sum(-Five, Three);

            // Assert
            Assert.Equal(-Five + Three, results);
        }

        [Fact]
        public void WhenSubFiveAndThreeThenGotTwo()
        {
            MathCalculator calculator = new MathCalculator();

            var result = calculator.Sub(Five, Three);

            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenNegSubFiveAndThreeThaenGotEight()
        {
            // Arrange
            MathCalculator calculator = new MathCalculator();

            // Act
            var result = calculator.Sub(-Five,Three);

            // Assert
            Assert.Equal(-8, result);
        }

        [Fact]
        public void WhenMultFiveAndThreeThenGotTwo()
        {
            MathCalculator calculator = new MathCalculator();

            var result = calculator.Mult(Five, Three);

            Assert.Equal(15, result);
        }

        [Fact]
        public void WhenDivFiveAndThreeThenGotTwo()
        {
            MathCalculator calculator = new MathCalculator();

            var result = calculator.Div(Five, Three);

            Assert.Equal(1, result);
        }
    }
}
