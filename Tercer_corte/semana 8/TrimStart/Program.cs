using System;

namespace TrimStart
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineWithLeadingSpaces = "     Its a class of data structure";
            string lineWithLeadingSymbols = "******its a class of data structure";
            string lineWithLeadingUnderscores = "_____its a class of data structure";
            string lineWithLeadingLetters = "pppppits a class of data structure";
            string lineAfterTrimStart = string.Empty;
            string[] lineas = { lineWithLeadingSpaces, lineWithLeadingSymbols, lineWithLeadingUnderscores, lineWithLeadingLetters };
            foreach (var line in lineas)
            {
                Console.WriteLine($"Las lineas tienen los siguientes caracteres {line}");
            }
            foreach (var lineaEditada in lineas)
            {
                Console.WriteLine(lineaEditada.TrimStart(' ', '*', '_', 'p'));
            }
        }
    }
}
