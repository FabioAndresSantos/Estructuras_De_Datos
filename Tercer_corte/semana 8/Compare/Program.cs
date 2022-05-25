using System;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            String palabra1 = "", palabra2 = "";
            Console.WriteLine("El programa comparara una cadena de caracteres");
            Console.ReadKey();
            Console.WriteLine("Ingrese la primera palabra");
            palabra1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda palabra");
            palabra2=Console.ReadLine();

            
            if (string.Compare(palabra1, palabra2) == 0)
            {
                Console.WriteLine($"Las palabras son iguales {palabra1} {palabra2}");
            }
            else
            {
                Console.WriteLine("Las palabras no son iguales");
            }
        }
    }
}
