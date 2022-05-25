using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Contains
{
    class Contains
    {
        static void Main(string[] args)
        {
            string s1 = "Hola amigos, ¿Cómo están?";
            string s2 = "amigos";
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' está en el string '{1}': {2}",s2, s1, b);
        }
    }
}
