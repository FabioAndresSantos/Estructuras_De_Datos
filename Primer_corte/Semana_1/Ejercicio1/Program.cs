using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ValorAbsoluto
{
    class program
    {
        static void Main(string[] args)
        {
            int Va, Num;
            Console.WriteLine("Escriba un numero sea negativo o positivo");
            Num = int.Parse(System.Console.ReadLine());
            if (Num <= 0)
            {
                Va = (Num * (-1));
                Console.WriteLine($"El Valor absoluto de {Num} es {Va}");
            }

            else
            {
                Va = Num;
                Console.WriteLine("El valor absoluto de {0} es {1} ", Num, Va);
            }
        }
    }
}
