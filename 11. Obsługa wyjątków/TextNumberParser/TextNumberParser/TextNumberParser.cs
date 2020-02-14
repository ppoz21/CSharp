using System;
namespace TextNumberParser
{
    public sealed class TextNumberParser
    {
        public static int Parse(string textDigit)
        {
            string[] digitTexts =
                { "zero", "jeden", "dwa", "trzy", "cztery",
            "pięć", "sześć", "siedem", "osiem", "dziewięć"};

            int result = Array.IndexOf(
                digitTexts,
                // wykorzystanie wprowadzonego w C# 2.0 operatora ??
                (textDigit ??
                // wykorzytanie wprowadzonego w C# 7.0 wyrażenia throw
                throw new ArgumentNullException(nameof(textDigit))
                ).ToLower());
            if (result < 0)
            {
                // Wykorzystanie wprowadzonego w C# 6.0 operatora nameof
                throw new ArgumentException(
                    "Argument nie reprezentuje cyfry",
                    nameof(textDigit));
            }

            return result;
        }
    }
}
