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

        [Fact]
        public void GenerateLCD_SingleDigit_ReturnsLCDRepresentation()
        {
            // Arrange
            var lcdDigits = new LCDDigits();

            // Act
            var result = lcdDigits.GenerateLCD("9");

            // Assert
            var expected = Align(
            @"._.
              |_|
              ..|");

            Assert.Equal(expected, result);
        }


        //helper function to pretty print digits
        public static string Align(string input)
        {
            return string.Join("\n", input.Split('\n').Select(line => line.Trim()));
        }
    }
}