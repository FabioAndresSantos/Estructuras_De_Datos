using System;

namespace Ejer8sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            do
            {
                double a, b, c, x1, x2, operacion;

                Console.WriteLine("solucion ecuaciones de segundo grado");
                Console.WriteLine("\n");
                Console.WriteLine("ingrese el valor 1");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el valor 2");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el valor 3");
                c = double.Parse(Console.ReadLine());

                operacion = b * b - 4.0 * a * c;

                if (operacion < 0)
                {
                    Console.WriteLine("los resultados son negativos ");
                    operacion = -operacion;
                }
                else

                    Console.WriteLine("los resultados son");

                x1 = (-b + Math.Sqrt(operacion)) / (2 * a);
                x2 = (-b - Math.Sqrt(operacion)) / (2 * a);

                Console.WriteLine("x1 =" + x1);
                Console.WriteLine("x2 =" + x2);

                Console.WriteLine("desea hacer otra operacion? si/no ");
                s = Console.ReadLine();
                Console.Clear();

            } while (s == "si");
        }
    }
}
