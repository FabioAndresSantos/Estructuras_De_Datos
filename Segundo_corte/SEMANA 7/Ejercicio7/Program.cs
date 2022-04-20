using System;
using System.Collections;
using System.Collections.Generic;
//Escriba una rutina que reciba una Pila P de numeros flotantes y devuelva una Cola manteniendo el orden
// de salida de los elementos.La Pila P no debe sufrir ningun cambio.
namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilaP = new Stack();
            Queue cola = new Queue();
            double cargarNumeros;

            pilaP.Push(5.5);
            pilaP.Push(10.6);
            pilaP.Push(47.1);
            pilaP.Push(84.45);
            pilaP.Push(78.21);
            while(pilaP.Count>0)
            {
                cargarNumeros = (double)pilaP.Pop();
                Console.WriteLine($"Los elementos de la pila: {cargarNumeros}");
                cola.Enqueue(cargarNumeros);
            }
            Console.Write(" ");
            imprimirNumerosDeCola(cola);
             static void imprimirNumerosDeCola(Queue colaNumeros)
            {
                foreach (double c in colaNumeros)
                    Console.WriteLine($" Los elementos de la cola son: {c}");
            }
        }
    }
}
