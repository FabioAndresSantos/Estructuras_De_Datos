using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Crear un programa que lea los precios de 5 artículos y las cantidades vendidas por una empresa en sus 4 
// sucursales. Imprimir las ventas de cada empresa e Informar:
// o Las cantidades totales de cada artículo.
// o La cantidad de artículos en la sucursal 2.
// o La cantidad del articulo 3 en la sucursal 1.
// o La recaudación total de cada sucursal.
// o La recaudación total de la empresa.
// o La sucursal de mayor recaudación.

namespace Transpuesta
{
    class Transpuesta
    {
        static void Main(string[] args)
        {
            int[,] Matriz = new int[5, 4];
            int limiteNumero = 9;
            int Sum = 0;
            int[] precio = new int [5];
            int r1=0,r2=0,r3=0,r4=0;
            int MAYOR=1;


            //Ingresar datos de los productos
            //f son los artìcuslo y c son las sucursales
            
            for(int f = 0; f < precio.Length; f++){
                Console.Write($"Introduce un valor para el articulo {f+1}: ");
                precio[f] = Convert.ToInt32(Console.ReadLine());
            }


            for (int f = 0; f < 5; f++){
                for (int c = 0; c < 4; c++){
                    Random numAleatorio = new Random();
                    Matriz[f, c] = numAleatorio.Next(1, limiteNumero);
                }
            }

            //Imprimir los productos por articulos/sucursal

            Console.WriteLine("\nLas ventas son: ");

            for (int f = 0; f < 5; f++){
                Console.Write($"Articulo {f+1}");
                for (int c = 0; c < 4; c++){
                    Console.Write($" Sucursal {c+1} [" + Matriz[f, c] + "] ");
                }
                Console.WriteLine();
            }
            
            //Sumatoria de los productos
            
            for (int f = 0; f < 5; f++){
                for (int c = 0; c < 4; c++){
                    Sum += Matriz [f,c];
                }
            }

            Console.WriteLine($"La cantidad de articulos totales son: {Sum}");

            Sum=0;

            //Sumatoria de los productos de la sucursal 2

            for (int f = 0; f < 5; f++){
                for (int c = 0; c < 4; c++){
                    if (c == 1){
                        Sum += Matriz [f,c];
                    }
                }
            }

            Console.WriteLine($"La cantidad de articulos totalesde la sucursal 2 son: {Sum}");

            //Sumatoria de los productos de la sucursal 1 del articulo 3

            for (int f = 0; f < 5; f++){
                for (int c = 0; c < 4; c++){
                    if (c == 0 && f == 2){
                        Console.Write($"Cantidad de articulos de la sucursal 1 del articulo 3 son: " + Matriz[f, c] + " ");
                    }
                }
            }

            //Recaudación total de cada sucursal

            int Sum1=0;
            
            for (int f = 0; f < 5; f++){
                for (int c = 0; c < 4; c++){
                    if (c == 0 ){
                        r1 =  precio[f]*Matriz [f,c];
                        Sum1 += r1;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"La Recaudación de la sucursal 1 fue: {Sum1}");

            int Sum2=0;
            
            for (int f = 0; f < 5; f++){
                for (int c = 0; c < 4; c++){
                    if (c == 1 ){
                        r2 =  precio[f]*Matriz [f,c];
                        Sum2 += r2;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"La Recaudación de la sucursal 2 fue: {Sum2}");

            int Sum3=0;
            
            for (int f = 0; f < 5; f++){
                for (int c = 0; c < 4; c++){
                    if (c == 2 ){
                        r3 =  precio[f]*Matriz [f,c];
                        Sum3 += r3;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"La Recaudación de la sucursal 3 fue: {Sum3}");

            int Sum4=0;
            
            for (int f = 0; f < 5; f++){
                for (int c = 0; c < 4; c++){
                    if (c == 3 ){
                        r4 =  precio[f]*Matriz [f,c];
                        Sum4 += r4;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"La Recaudación de la sucursal 4 fue: {Sum4}");

            //La recaudación total de la empresa.

            int TSum = Sum1+Sum1+Sum3+Sum4;
            Console.WriteLine($"La Recaudación total de la empresa fue: {TSum}");
            
            //La sucursal de mayor recaudación

            if (Sum1 > Sum2 && Sum1 > Sum3 && Sum1 > Sum4)
            {
                Console.WriteLine($"La Sucursal con mayor recaudación fue la 1");
            }

            if (Sum2 > Sum1 && Sum2 > Sum3 && Sum2 > Sum4)
            {
                Console.WriteLine($"La Sucursal con mayor recaudación fue la 2");
            }

            if (Sum3 > Sum2 && Sum3 > Sum1 && Sum3 > Sum4)
            {
                Console.WriteLine($"La Sucursal con mayor recaudación fue la 3");
            }

            if (Sum4 > Sum1 && Sum4 > Sum2 && Sum4 > Sum3)
            {
                Console.WriteLine($"La Sucursal con mayor recaudación fue la 4");
            }
        }
    }
}