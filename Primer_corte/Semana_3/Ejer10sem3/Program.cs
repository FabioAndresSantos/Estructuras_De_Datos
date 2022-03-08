using System;

namespace Ejer10sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1, p2, p3, OP;
            Console.WriteLine("ingrese numero de vacunados sede 1  ");
            p1 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("ingrese numero de vacunados sede 2  ");
            p2 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("ingrese numero de vacunados sede 3  ");
            p3 = int.Parse(System.Console.ReadLine());

            p1 = 1000 - p1;
            p2 = 1000 - p2;
            p3 = 1000 - p3;

            if (p1 <= 200)
                Console.WriteLine($" la cantidad es menor a 200 vacunas , en total hay {p1} ");
            if (p2 <= 200)
                Console.WriteLine($" la cantidad es menor a 200 vacunas , en total hay  {p2} ");
            if (p3 <= 200)
            {
                Console.WriteLine($" la cantidad es menor a 200 vacunas , en total hay  {p3} ");
            }

            Console.WriteLine($"el inventario final de las 3 sedes es {p1 + p2 + p3}");

        }
    }
}
