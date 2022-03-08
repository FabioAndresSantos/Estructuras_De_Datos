using System;

namespace Ejercicio9sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ope ="T", ope1="t";
            string ope2 = "C", ope3 = "c";
            string var = "";
            float bas=0 , altura = 0, rad=0;
            float res = 0, res1 = 0;
            float pi = 3.141592F;
            int sw = 0;
            Console.WriteLine("Triangulo");
            Console.WriteLine("Circulo");

            Console.WriteLine("Ingrese la inicial de la figura que desea operar");
            Console.WriteLine("");
            var =Console.ReadLine();
            if (sw == 0)
            {
                if (var == ope || var == ope1)
                {
                    Console.WriteLine("Ingrese la base del triangulo");
                    bas = float.Parse(System.Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triangulo");
                    altura = float.Parse(System.Console.ReadLine());
                    res = ((bas * altura) / 2);
                    Console.WriteLine($"El resultad0 del area del triangulo es: {res}");
                }
                if (var == ope2 || var == ope3)
                {
                    Console.WriteLine("Ingrese el radio del circulo ");
                    rad = float.Parse(System.Console.ReadLine());
                    res1 = (pi * (rad * rad));
                    Console.WriteLine($"El área del circulo es {res1}");
                }
            }
            else
            {
                Console.WriteLine("No se encontro la operacion para la figura que desea operar");
            }
        }
    }
}
