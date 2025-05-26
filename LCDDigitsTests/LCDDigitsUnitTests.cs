using LCDDigitsLibrary;

namespace LCDDigitsTests
{
    public class LCDDigitsUnitTests
    {
        [Fact]
        public void GenerateLCD_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            var lcdDigits = new LCDDigits();

            // Act
            var result = lcdDigits.GenerateLCD("");

            // Assert
            Assert.Equal("", result);
        }
    }
}