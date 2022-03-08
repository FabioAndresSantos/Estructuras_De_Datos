using System;

namespace Ejer5sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            string modo = "";

            Console.WriteLine("Ingrese cuatro numeros que no se repitan");
            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            c = int.Parse(System.Console.ReadLine());
            d = int.Parse(System.Console.ReadLine());
            if (a != b && a != c && a != d && b != c && b != d && c != d)
            {
                Console.WriteLine("Ingrese 'mayor' o 'menor' para hacer el proceso correspondiente");
                modo = Console.ReadLine();
                switch (modo)
                {
                    case "mayor":
                        if (a > b && a > c && a > d)
                        {
                            Console.WriteLine($"El mayor es {a}");
                        }
                        if (b > a && b > c && b > d)
                        {
                            Console.WriteLine($"El mayor es {b}");
                        }
                        if (c > a && c > b && c > d)
                        {
                            Console.WriteLine($"El mayor es {c}");
                        }
                        if (d > a && d > b && d > c)
                        {
                            Console.WriteLine($"El mayor es {d}");
                        }
                        break;

                    case "menor":
                        if (a < b && a < c && a < d)
                        {
                            Console.WriteLine($"El menor es {a}");
                        }
                        if (b < a && b < c && b < d)
                        {
                            Console.WriteLine($"El menor es {b}");
                        }
                        if (c < a && c < b && c < d)
                        {
                            Console.WriteLine($"El menor es {c}");
                        }
                        if (d < a && d < b && d < c)
                        {
                            Console.WriteLine($"El menor es {d}");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Tienen que ser diferentes");
            }

        }
    }
}
