using System;

namespace Ejer2sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 0;
            Console.WriteLine("digite el tamaño de la piramide");

            var = int.Parse(Console.ReadLine());

            int val = var;

            if (var % 2 == 0)


                for (int i = 0; i < val; i++)
                {
                    Console.WriteLine(new String(' ', val - i - 1) + new String('*', i + i + 1));
                }

            else
                Console.WriteLine("el valor es negativo");
            Console.ReadLine();
        }
    }
}
