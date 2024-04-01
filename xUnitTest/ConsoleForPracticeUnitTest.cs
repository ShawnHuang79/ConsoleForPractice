namespace ConsoleForPractice.Tests
{
    public class ConsoleForPracticeUnitTest
    {
        [Theory]
        [InlineData(121, 10, true)]
        [InlineData(123, 10, false)]
        [InlineData(5, 10, true)]
        [InlineData(0b101, 2, true)]
        [InlineData(0b1010, 2, false)]
        [InlineData(0b10101, 2, true)]
        [InlineData(7, 8, true)]
        [InlineData(8, 8, false)]
        [InlineData(65, 8, true)]

        public void IsPalindrome_ShouldIdentifyPalindromeCorrectly(int number, int baseSystem, bool expected)
        {
            // Act
            bool result = ConsoleForPractice.Program.IsPalindrome(number, baseSystem);

            // Assert
            Assert.Equal(expected, result);
        }


        [Fact]
        public void GetValidNumber_ReturnsExpectedValue()
        {
            // Arrange
            var input = "123\n";
            Console.SetIn(new StringReader(input));

            // Act
            int result = ConsoleForPractice.Program.GetValidNumber();

            // Assert
            Assert.Equal(124, result); 
        }
    }


}