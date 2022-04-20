using System;
using System.Collections;
using System.Collections.Generic;
// Escriba un programa que inserte valores ordenadamente en una lista.
// La lista/pila/cola debe almacenar números enteros. 
// El programa debe leer una secuenci ade números enteros de la entrada hasta que se ingrese el número cero.
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilaP = new Stack();
            int sw = 0;
            int a;
            while ( sw == 0){
                Console.WriteLine($"Ingrese el elemento de la pila");
                a = int.Parse(Console.ReadLine());
                pilaP.Push(a);
                if (a == 0){
                    sw = 1;
                }
        }
    }
}
}