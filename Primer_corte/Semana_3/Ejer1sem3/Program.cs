using System;

namespace Ejer1sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nu = 0, j = 1;
            Console.WriteLine("Digite un numero");
            nu = int.Parse(System.Console.ReadLine());
            Console.WriteLine("");
            for (int i = 1; i <= nu; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
