using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Crear una matriz de 5x5 ingresando los números a cada que calcule e imprima la transpuesta de una 
// matriz. La transpuesta de una matriz se obtiene al escribir las filas de la matriz como columnas y las 
// columnas como filas.


namespace Transpuesta
{
    class Transpuesta
    {
        static void Main(string[] args)
        {
            int[,] Matriz = new int[5, 5];

            //Ingresar datos a la matriz

            for (int f = 0; f < 5; f++){
                for (int c = 0; c < 5; c++){
                    Console.Write($"Ingrese el elemento {f+1}, {c+1} del la matriz: ");
                    Matriz[f,c] = int.Parse(System.Console.ReadLine());
                }
            }

            //Imprimir matriz

            Console.WriteLine("\nLa matriz es");

            for (int f = 0; f < 5; f++){
                for (int c = 0; c < 5; c++){
                    Console.Write("    [" + Matriz[f, c] + "] ");
                }
                Console.WriteLine();
            }

            //Invertir valores: f,c->c,f para hacer la transpuesta e imprimir.

            Console.WriteLine("\nLa matriz transpuesta es");

            for (int f = 0; f < 5; f++){
                for (int c = 0; c < 5; c++){
                    Console.Write("    [" + Matriz[c, f] + "] ");
                }
                Console.WriteLine();
            }
        }
    }
}