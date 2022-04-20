using System;
using System.Collections;
//Escriba una rutina que reciba una PilaP de números enteros ydevuelva una copia exacta de la misma.
//Es de destacar que laPilaP no debe sufrir ningún tipode cambioo alteración.

namespace Arraylist9
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilaNumerosAlmacenados;
            ArrayList pilaP = new ArrayList();
            ArrayList pilaPn= new ArrayList();
            Console.WriteLine("Ingrese el tamaño  de la pila:");
            int pila = int.Parse(System.Console.ReadLine()); 
            for(int pilaNumeros = 0; pilaNumeros < pila; pilaNumeros++)
            {
                Console.WriteLine($"Ingrese elemento {pilaNumeros+1}");
                pilaNumerosAlmacenados = int.Parse(System.Console.ReadLine());
                pilaP.Add(pilaNumerosAlmacenados);
            }
            pilaP.Sort();
            imprimir(pilaP);
            Console.WriteLine("Copia de la pilaP");
            Console.WriteLine(" ");
            imprimir(pilaP);
            static void imprimir(ArrayList arreglo)
            {
                foreach (int p in arreglo)
                    Console.Write($" {p}");
                Console.WriteLine("\n-----------");
            }
        }
    }
}
