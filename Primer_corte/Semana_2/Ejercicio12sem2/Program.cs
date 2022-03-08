using System;

namespace Ejercicio12sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double d = 0, a = 0;

            Console.WriteLine("Ingrese el valor por metro");
            x = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de metros");
            y = int.Parse(System.Console.ReadLine());
            a = x * y;
            if (y < 20)
            {
                Console.WriteLine("El total es {0}", a);
            }
            if (y >= 20 && y < 40)
            {
                d = (a * 5) / 100;
                a = a - d;
                Console.WriteLine("El total es {0}", a);
            }
            if (y > 40)
            {
                d = (a * 12) / 100;
                a = a - d;
                Console.WriteLine("El total es {0}", a);
            }
        }
    }
}