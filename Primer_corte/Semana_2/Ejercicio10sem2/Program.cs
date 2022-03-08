using System;

namespace Ejercicio10sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a = 0, b = 0, c = 0, d = 0;

            Console.WriteLine("Ingrese la medida del largo");
            x = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese la medida del ancho");
            y = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese el valor por metro cuadrado del terreno");
            b = int.Parse(System.Console.ReadLine());
            a = x * y;
            c = a * b;
            if (a < 400)
            {
                Console.WriteLine("El precio del terreno es {0}", c);

            }
            if (a >= 400 && a < 500)
            {
                d = (c * 10) / 100;
                c = c - d;
                Console.WriteLine("El precio del terreno es {0}", c);
            }
            if (a >= 500 && a < 1000)
            {
                d = (c * 17) / 100;
                c = c - d;
                Console.WriteLine("El precio del terreno es {0}", c);
            }
            if (a > 1000)
            {
                d = (c * 25) / 100;
                c = c - d;
                Console.WriteLine("El precio del terreno es {0}", c);
            }
        }
    }
}

