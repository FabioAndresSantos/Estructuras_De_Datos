using System;
//Diseñar el algoritmo correspondiente a un programa, que:oCrea una tabla bidimensional de longitud 5x15
//y nombre ‘marco’.oCarga la tabla con dos únicos valores 0 y 1,
//donde el valor uno ocupará las posiciones o elementos que delimitan la tabla,
//es decir, las más externas,
//mientras que el resto de los elementos contendrán el valor 0.
//oVisualiza el contenido de la matriz en pantalla.

namespace Ejercicio9
{
    class Program
    {
            static void Main(string[] args)
            {
                string[] Dimensiones= new string[5];

                Dimensiones[4] = "111111111111111";
                Dimensiones[1] = "100000000000001";
                Dimensiones[3] = "100000000000001";
                Dimensiones[2] = "100000000000001";
                Dimensiones[0] = "111111111111111";
                Console.WriteLine("MARCO");
                Console.WriteLine($"{Dimensiones[0]}");
                Console.WriteLine($"{Dimensiones[1]}");
                Console.WriteLine($"{Dimensiones[2]}");
                Console.WriteLine($"{Dimensiones[3]}");
                Console.WriteLine($"{Dimensiones[4]}");
            }
        }
    }

