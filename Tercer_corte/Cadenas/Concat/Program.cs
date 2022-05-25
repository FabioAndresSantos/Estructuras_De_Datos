using System;
using System.Collections;
using System.Collections.Generic;

namespace Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            String palabra1 = "Hola ", palabra2="Mundo ", palabra3 = "Bello", palabra4 ="...", palabra5 = "";
            palabra5 = string.Concat(palabra1 , palabra2 , palabra3 , palabra4 );
            Console.WriteLine($"El mensaje es: {palabra5}");
        }
    }
}
