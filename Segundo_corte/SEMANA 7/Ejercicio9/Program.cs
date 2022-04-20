using System;
using System.Collections;
using System.Collections.Generic;
//Escriba una rutina que reciba una Cola C de numeros enteros y mueva sus elementos a una nueva Pila, pero invirtiendo el orden de salida de 
// los elementos, al finalizar la Cola C no debe tener elementos.
namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue colaC = new Queue();
            Stack pila = new Stack();

            colaC.Enqueue(10);
            colaC.Enqueue(14);
            colaC.Enqueue(25);
            colaC.Enqueue(47);

            Console.WriteLine("La cola inicial es: ");
            while (colaC.Count > 0)
            {
                int cola = 0;
                cola = (int)colaC.Dequeue();
                Console.WriteLine($" Cola: {cola}");
                pila.Push(cola);
            }
            Console.WriteLine("La pila creada es: ");
            while (pila.Count > 0)
            {
                Console.WriteLine($" Pila {pila.Pop()}");
            }
            colaC.Clear();
            if (colaC.Count == 0)
            {
                Console.WriteLine("No existe elementos dentro de la cola");
            }
            
        }
    }
}
