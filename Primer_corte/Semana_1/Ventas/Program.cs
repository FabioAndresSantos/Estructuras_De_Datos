using System;
namespace VentasABC
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            System.Console.WriteLine("Las ventas de A son las más elevadas, las de C son los menos vendidas, C no puede ser inferior a 200 y A tiene que ser mayor a 400");
            System.Console.WriteLine("Las ventas están entre 500 y 1000");
            System.Console.WriteLine("Ingrese las ventas de A");
            a = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Ingrese las ventas de B");
            b = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Ingrese las ventas de C");
            c = int.Parse(System.Console.ReadLine());
            int d = a + b + c;

            if (a > b && a > c)
            {
                if (a > 400)
                {
                    if (b > c)
                    {
                        if (d <= 1000)
                        {
                            System.Console.WriteLine("Felicidades, las condiciones se cumplen");
                        }
                        else
                        {
                            System.Console.WriteLine("La suma de las ventas debes ser menor o igual a 1000");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Las ventas del producto B tienen que ser mayores a C");
                    }
                }
                else
                {
                    System.Console.WriteLine("Las ventas del producto A tienen que ser mayores a 400");
                }
            }
            else
            {
                System.Console.WriteLine("Las ventas del producto A fueron menores que las de b y de c");
            }


        }
    }
}

