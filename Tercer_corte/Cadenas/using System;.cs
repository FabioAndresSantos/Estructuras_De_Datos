using System;
using System.Collections;
using System.Collections.Generic;
namespace SubString_EndWith_Split_Trim
{
    class Program
    {
        static void Main(string[] args)
        {
                    case 1:
                        Console.WriteLine("Ingrese una cadena ");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine($"Estos son los valores desde el segundo valor hasta el cuarto: {Cadena.Substring(1, 4)}");
                        Console.WriteLine("");
                    break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una cadena ");
                        Cadena = Console.ReadLine();

                        if(Cadena.EndsWith("i"))
                        {
                            Console.WriteLine("");
			                Console.WriteLine("Termina en la letra i");
		                }
                        
                        else
                        {
                            Console.WriteLine("");
			                Console.WriteLine("No termina en i");
		                }
                    break;
                    case 3:
                        string Palabra = "Jugar en la noche. Jugar en la mañana.";
                        Console.WriteLine("");
                        string[] OtraPalabra = Palabra.Split(' ', '.');

                        foreach (var b in OtraPalabra)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"Subcadena: {b}");
                        }
                   case 4:
                        Console.WriteLine("");
                        Console.WriteLine(" primer nombre: ");
                        string Nombre1 = Console.ReadLine();
                        
                        Console.WriteLine("");
                        Console.WriteLine(" segundo nombre o inicial: ");
                        string Nombre2 = Console.ReadLine();
      
                        Console.WriteLine("");
                        Console.Write("Ingrese ultimo nombre: ");
                        string Nombre3 = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine($"Esto es {Nombre1}, {Nombre2}, y {Nombre3}.");
      
                        Console.WriteLine("");
                        string Nombres = ((Nombre1.Trim() + " " + Nombre2.Trim()).Trim() + " " + Nombre3.Trim()).Trim();
                        Console.WriteLine("Este es el resultado " + Nombres + ".");
                    break;
           }
      }
}