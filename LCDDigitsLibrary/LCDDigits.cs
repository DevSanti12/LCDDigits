using System.Collections.Generic;

namespace LCDDigitsLibrary
{
    public class LCDDigits
    {
        private readonly Dictionary<char, string[]> _lcdMapped = new Dictionary<char, string[]>
        {
            { '0', new[] { "._.", "|.|", "|_|" } },
            { '1', new[] { "...", "..|", "..|" } },
            { '2', new[] { "._.", "._|", "|_." } },
            { '3', new[] { "._.", "._|", "._|" } },
            { '4', new[] { "...", "|_|", "..|" } },
            { '5', new[] { "._.", "|_.", "._|" } },
            { '6', new[] { "._.", "|_.", "|_|" } },
            { '7', new[] { "._.", "..|", "..|" } },
            { '8', new[] { "._.", "|_|", "|_|" } },
            { '9', new[] { "._.", "|_|", "..|" } },
        };


        public string GenerateLCD(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }

            var lcdPrint = new List<string>
            {
                "", "", "" //place holders
            };

            foreach(var digit in input)
            {
                if (!_lcdMapped.ContainsKey(digit))
                    throw new ArgumentException($"Invalid character in input: {digit}");
                
                var lcdRepresentation = _lcdMapped[digit];
                lcdPrint[0] += lcdRepresentation[0] + "";
                lcdPrint[1] += lcdRepresentation[1] + "";
                lcdPrint[2] += lcdRepresentation[2] + "";
                
            }
            return string.Join("\n", lcdPrint).TrimEnd();
        }
    }
}
