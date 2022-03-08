using System;

namespace Ejercicio4sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            string var = "M";
            string var1 = "m";


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número:");
                numeros[i] = int.Parse(Console.ReadLine());
            }


            Array.Sort(numeros);
            Console.WriteLine("Ingrese (M) para que el orden sea de mayor a menor");
            Console.WriteLine("Ingrese (m) para que el orden sea de menor a mayor");
            string or = "";
            or = Console.ReadLine();
            if (var1 == or)
            {
                Console.WriteLine("\nEl orden numerico:");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
            if (var ==or )
            {
                Console.WriteLine("\nEl orden numerico");
                for(int i=10;i<0;i--)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

           
        }
    }
}
