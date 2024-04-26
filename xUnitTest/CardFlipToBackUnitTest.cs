namespace CardFlipToBack.Tests
{
    public class CardFlipToBackUnitTest
    {
        [Theory]
        [InlineData (2, false)]
        [InlineData(10, false)]
        [InlineData(16, true)]

        public void IsCardFlipToBackCorrectly(int number, bool expected)
        {
            //Act
            bool result = CardFlipToBack.Program.IsFactorEven(number);

            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestIsFactorEvenFor81()
        {
            // Arrange
            int number = 81;

            // Act
            bool result = Program.IsFactorEven(number);

            // Assert
            Assert.True(result);
        }

    }
}
