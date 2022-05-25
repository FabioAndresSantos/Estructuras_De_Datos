using System;

namespace Padleft1
{
    class Padleft{
        static void Main(string[] arg)
        {
            string str = "Moviendo de la margen";
            char pad = '.';
            Console.WriteLine(str.PadLeft(20, pad));  
            Console.WriteLine(str.PadLeft(5, pad));   
        }
    }
}