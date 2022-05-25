using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Equals
{
    class Equals
    {
        static void Main(string[] args)
        {
            string s1 = "Hola mundo";
            string s2 = "Hola mundo";
            Console.WriteLine("Variable 1: {0} y variable 2: {1}. ", s1, s2);
            Console.WriteLine("Igualdad: ");
            Console.Write(s1.Equals(s2));
            Console.WriteLine("");
            string s3 = "Hola princesa";
            string s4 = "Hola reina";
            Console.WriteLine("Variable 3: {0} y variable 4: {1}. ", s3, s4);
            Console.WriteLine("Igualdad: ");
            Console.Write(s3.Equals(s4));
        }
    }
}
