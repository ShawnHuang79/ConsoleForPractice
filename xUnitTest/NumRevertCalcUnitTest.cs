using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NumRevertCalcUnit.Tests
{
    public class NumRevertCalcUnitTest
    {
        [Theory]
        [InlineData(1210, false)]
        [InlineData(1430,  false)]
        [InlineData(5931, true)]

        public void IsNumRevertCalcCorrectly(int number, bool expected)
        {
            // Act
            bool result = NumRevertCalc.Program.CanReverseByMultiplication(number);

            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void ReturnsExpectedValue()
        {
            //Arrange
            int input = 5931;

            //Act
            bool result = NumRevertCalc.Program.CanReverseByMultiplication(input);

            //Assert
            Assert.True(result);
        }

    }
}
