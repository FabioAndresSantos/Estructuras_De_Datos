using System;

namespace Ejer3sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, x;

            Console.WriteLine("Ingrese 5 valores para los asteriscos");
            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            c = int.Parse(System.Console.ReadLine());
            d = int.Parse(System.Console.ReadLine());
            e = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Para el primero es: ");
            for (x = 0; x < a; x++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Para el segundo es: ");
            for (x = 0; x < b; x++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Para el tercero es: ");
            for (x = 0; x < c; x++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Para el cuarto es: ");
            for (x = 0; x < d; x++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Para el quinto es: ");
            for (x = 0; x < e; x++)
            {
                Console.Write("*");
            }
        }
    }
}
