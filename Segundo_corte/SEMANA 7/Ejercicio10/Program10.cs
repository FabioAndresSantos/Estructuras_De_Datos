using System;
using System.Collections;

namespace Ejercicio_10
{
    class Ejercicio_10
    {
            static void Main(string[] args)
        {

            
            Queue Cola = new Queue();
            Stack Pila = new Stack();

            
            Cola.Enqueue(1);
            Cola.Enqueue(2);
            Cola.Enqueue(3);
            Cola.Enqueue(4);

            Console.WriteLine("La cola inicial es: ");

            while (Cola.Count > 0)
            {
                int Col = 0;
                Col = (int)Cola.Dequeue();
                Console.WriteLine($"  Cola: {Col}");
                Pila.Push(Col);
            }
            Console.WriteLine("Se creó una pila: ");
            while (Pila.Count > 0)
            {
                Console.WriteLine($"  Pila: {Pila.Pop()}");
            }
            Console.WriteLine("ya no hay elementos en la Pila.");
        }
    }
}

