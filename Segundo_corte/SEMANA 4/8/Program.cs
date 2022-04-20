using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Queremos almacenar en una matriz el número de alumnos con el que cuenta una 
// academia, ordenados en función del nivel y del idioma que se estudia. Tendremos 3 filas 
// que representarán al Nivel básico, medio y de perfeccionamiento y 4 columnas en las que 
// figurarán los idiomas (0 = Inglés, 1 = Francés, 2 = Alemán y 3 = Ruso). Se pide realizar la 
// declaración de la matriz y asignarle unos valores de ejemplo a cada elemento

namespace Alumnos
{
    class Alumnos
    {
        static void Main(string[] args)
        {
            int LONGITUD_FILA_MATRIZ = 3;
            int LONGITUD_COLUMNA_MATRIZ = 4;
            int[,] Matriz = new int[3, 4];

            for (int f = 0; f < LONGITUD_FILA_MATRIZ; f++){
                for (int c = 0; c < LONGITUD_COLUMNA_MATRIZ; c++){
                    Console.Write($"Ingrese el elemento {f+1}, {c+1} del la matriz: ");
                    Matriz[f,c] = int.Parse(System.Console.ReadLine());
                }
            }

            Console.WriteLine("\nLa matriz resultante es");

            for (int f = 0; f < LONGITUD_FILA_MATRIZ; f++){
                for (int c = 0; c < LONGITUD_COLUMNA_MATRIZ; c++){
                    Console.Write("    [" + Matriz[f, c] + "] ");
                }
                Console.WriteLine();
            }
        }
    }
}