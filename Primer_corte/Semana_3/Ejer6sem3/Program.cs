using System;

namespace Ejer6sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nu, swich = 0;
            string re = "";
            while (swich == 0)
            {
                Console.WriteLine("digite un numero que este entre 100 y 200");
                Nu = int.Parse(System.Console.ReadLine());

                if (Nu >= 100)
                {
                    Console.WriteLine("los numeros pares son");
                    for (int i = Nu; i <= 200; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (Nu < 100 || Nu > 200)
                    Console.WriteLine("el numero que ha ingresado esta fuera del rango");
                Console.WriteLine("desea volver a intentarlo?");
                Console.WriteLine("presione S para intentarlo de nuevo o N para salir");
                re = Console.ReadLine();
                if (re == "S" || re == "s")
                {
                    swich = 0;
                }
                else if (re == "N" || re == "n")
                {
                    swich = 1;
                }
            }
        }
    }
}
