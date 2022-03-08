using System;

namespace Ejercicio11sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, l, g, e, t;

            Console.WriteLine("Ingrese el precio del Agua");
            a = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese el precio de la Luz");
            l = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese el precio del Gas");
            g = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese el estrato al que pertenece");
            e = int.Parse(System.Console.ReadLine());
            if (e == 1)
            {
                a = a - (a * 20) / 100;
                l = l - (l * 20) / 100;
                g = g - (g * 20) / 100;
                t = a + l + g;
                Console.WriteLine("El precio total es {0}", t);
            }
            if (e == 2)
            {
                a = a - (a * 15) / 100;
                l = l - (l * 15) / 100;
                g = g - (g * 15) / 100;
                t = a + l + g;
                Console.WriteLine("El precio total es {0}", t);
            }
            if (e >= 3)
            {
                a = a - (a * 9) / 100;
                l = l - (l * 9) / 100;
                g = g - (g * 9) / 100;
                t = a + l + g;
                Console.WriteLine("El precio total es {0}", t);
            }
        }
    }
}
