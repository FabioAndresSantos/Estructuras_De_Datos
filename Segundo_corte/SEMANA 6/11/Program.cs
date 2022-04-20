using System;
using System.Collections;
//Escriba una rutina que reciba una PilaP de números flotantes y devuelva una Cola
//manteniendo el orden de salida de los elementos.
//Es de destacar que la PilaP no debe sufrir ningún tipo de cambio o alteración.

namespace Arraylist11
{
    class Program
    {
        static void Main(string[] args)
        {
            float numeroPila;
            float pila, pilaP;
            Console.WriteLine("Ingrese el tamaño de la pila");
            numeroPila = float.Parse(System.Console.ReadLine());
            ArrayList pilaNumeros = new ArrayList();
            for(pila=0;pila<numeroPila;pila++)
            {
                Console.WriteLine($"Ingrese elemento {pila+1}");
                pilaP = float.Parse(System.Console.ReadLine());

                pilaNumeros.Add(pilaP);
            }
            imprimirPilaDeNumeros(pilaNumeros);

            static void imprimirPilaDeNumeros(ArrayList arreglo)
            {
                foreach (float p in arreglo)
                    Console.WriteLine($" {p} ");
                Console.WriteLine("\n--------------------");
            }
            
        }
    }
}
