using System;

namespace trimEnd
{
    class trimEnd
    {
        static void Main(string[] args)
        {
                string sentence = "Hola gente, soy Esteban y tengo la novia más preciosa del mundo.";
                char[] charsToTrim = {',', '.', ' '};
                string[] words = sentence.Split();
                foreach (string word in words)
                Console.WriteLine(word.TrimEnd(charsToTrim));
        }
    }
}
