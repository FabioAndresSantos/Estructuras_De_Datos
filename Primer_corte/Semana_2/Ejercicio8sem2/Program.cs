using System;

namespace Ejercicio8sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 0;
            Console.WriteLine("Ingrese el mes");
            Console.WriteLine("1-- Enero");
            Console.WriteLine("2-- Febrero");
            Console.WriteLine("3-- Marzo");
            Console.WriteLine("4-- Abril");
            Console.WriteLine("5-- Mayo");
            Console.WriteLine("6-- Junio");
            Console.WriteLine("7-- Julio");
            Console.WriteLine("8-- Agosto");
            Console.WriteLine("9-- Septiembre");
            Console.WriteLine("10-- Octubre");
            Console.WriteLine("11-- Noviembre");
            Console.WriteLine("12-- Diciembre");
            Console.WriteLine("");
            mes = int.Parse(System.Console.ReadLine());
            if(mes<=12)
            {
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Enero tiene 31 dias ");
                        break;
                    case 2:
                        Console.WriteLine("Febrero tiene 28 dias");
                        break;
                    case 3:
                        Console.WriteLine("Marzo tiene 31 dias");
                        break;
                    case 4:
                        Console.WriteLine("Abril tiene 30 dias");
                        break;
                    case 5:
                        Console.WriteLine("Mayo tiene 31 dias ");
                        break;
                    case 6:
                        Console.WriteLine("Junio tiene 30 dias");
                        break;
                    case 7:
                        Console.WriteLine("Julio tiene 31 dias");
                        break;
                    case 8:
                        Console.WriteLine("Agosto tiene 31 dias");
                        break;
                    case 9:
                        Console.WriteLine("Septiembre tiene 30 dias");
                        break;
                    case 10:
                        Console.WriteLine("Octubre tiene 31 dias");
                        break;
                    case 11:
                        Console.WriteLine("Noviembre tiene 30 dias");
                        break;
                    case 12:
                        Console.WriteLine("Diciembre tiene 31 dias");
                        break;
                    default:
                        Console.WriteLine("No se encontro el mes");
                        break;
                }
                    }
            else
            {
                Console.WriteLine("Ha ingresado un mes inexistente");
            }
            Console.WriteLine("Gracias por utilizar el programa");
        }
    }
}
