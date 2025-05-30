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

        [Fact]
        public void GenerateLCD_MultipleDigits_ReturnsLCDRepresentation()
        {
            // Arrange
            var lcdDigits = new LCDDigits();

            // Act
            var result = lcdDigits.GenerateLCD("910");

            // Assert
            var expected = Align(
            @"._....._.
              |_|..||.|
              ..|..||_|");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GenerateLCD_NonDigitInput_ThrowsArgumentException()
        {
            // Arrange
            var lcdDigits = new LCDDigits();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => lcdDigits.GenerateLCD("9a1"));
        }

        [Fact]
        public void GenerateLCD_AllDigits_ReturnsFullLCDRepresentation()
        {
            var lcdDigits = new LCDDigits();
            var result = lcdDigits.GenerateLCD("0123456789");
            var expected =Align(
        @"._....._.._....._.._.._.._.._.
          |.|..|._|._||_||_.|_...||_||_|
          |_|..||_.._|..|._||_|..||_|..|");
            Assert.Equal(expected, result);
        }

        //helper function to pretty print digits
        public static string Align(string input)
        {
            return string.Join("\n", input.Split('\n').Select(line => line.Trim()));
        }
    }
}