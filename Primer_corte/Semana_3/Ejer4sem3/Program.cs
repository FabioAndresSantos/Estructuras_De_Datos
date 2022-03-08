using System;

namespace Ejer4sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            float x = 0;

            Console.WriteLine("Ingrese hasta que numero quiere llegar");
            a = float.Parse(System.Console.ReadLine());

            for (float i = 1; i <= a; i++)
            {
                b = 1 / i;
                x = b + x;
            }
            Console.WriteLine("sumatoria {0}", x);
        }
    }
}
