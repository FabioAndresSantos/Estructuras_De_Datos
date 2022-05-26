using System;

namespace trimEnd
{
    class trimEnd
    {
        static void Main(string[] args)
        {
                string sentence = "Hola gente, como estan el dia de hoy.";
                char[] charsToTrim = {',', '.', ' '};
                string[] words = sentence.Split();
                foreach (string word in words)
                Console.WriteLine(word.TrimEnd(charsToTrim));
        }
    }
}
