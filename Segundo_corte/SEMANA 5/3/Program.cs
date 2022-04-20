using System;
//Define un array de números enteros de 3 filas por 6 columnas con nombre num y asigna
//los valores cuando se inicie el programa.
//Muestra el contenido de todos los elementos del arraydispuestos en forma de tabla.

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabla números");
            int[,] array;
            int numeroDeFilas = 3, filas;
            int numeroDeColumnas = 6, columnas;
            array =new int[numeroDeFilas, numeroDeColumnas];
            for (filas = 0; filas < numeroDeFilas; filas++)
            {
                for (columnas = 0; columnas < numeroDeColumnas; columnas++)
                {
                    Console.WriteLine($"Ingrese valores {filas+1} {columnas+1}  ");
                    array[filas, columnas] = int.Parse(System.Console.ReadLine());
                }
            }
            Console.WriteLine("Tabla de números");
            for (filas = 0; filas < array.GetLength(0); filas++)
            {
                for (columnas = 0; columnas < array.GetLength(1); columnas++)
                {
                    Console.Write("  | "+array[filas,columnas]+" |  ");
                }
                Console.WriteLine();
            }
        }
    }
}
