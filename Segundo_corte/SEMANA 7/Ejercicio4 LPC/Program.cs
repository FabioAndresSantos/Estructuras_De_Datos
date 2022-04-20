using System;
using System.Collections;
using System.Collections.Generic;
//Escriba un programa que dados dos lista/pila/cola ordenadas de numeros enteros
//realice concatenacion en forma ordenada de ambas lista/pila/cola.

namespace Ejercicio4Listas_Colas_Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista1 = new ArrayList();
            ArrayList lista2 = new ArrayList();
            Queue cola1 = new Queue();
            Queue cola2 = new Queue();
            Stack pila1 = new Stack();
            Stack pila2 = new Stack();
            //Elementos número 1.
            lista1.Add(5);
            lista1.Add(4);
            lista1.Add(10);
            cola1.Enqueue(45);
            cola1.Enqueue(47);
            cola1.Enqueue(12);
            pila1.Push(47);
            pila1.Push(11);
            pila1.Push(98);
            //Elementos número 2.
            lista2.Add(8);
            lista2.Add(9);
            lista2.Add(50);
            cola2.Enqueue(85);
            cola2.Enqueue(14);
            cola2.Enqueue(17);
            pila2.Push(93);
            pila2.Push(13);
            pila2.Push(3);
            Console.WriteLine("La primera lista es: ");
            imprimirLista(lista1);
            Console.WriteLine("La segunda lista es: ");
            imprimirLista(lista2);
            Console.WriteLine("La primera cola es: ");
            imprimirCola(cola1);
            Console.WriteLine("La segunda cola es: ");
            imprimirCola(cola2);
            Console.WriteLine("La primera pila es: ");
            imprimirPila(pila1);
            Console.WriteLine("La segunda pila es: ");
            imprimirPila(pila2);
            lista1.AddRange(lista2);
            lista1.AddRange(cola1);
            lista1.AddRange(cola2);
            lista1.AddRange(pila1);
            lista1.AddRange(pila2);
            Console.WriteLine("La concatenacion es:");
            imprimirConcatenacion(lista1);
            static void imprimirLista(ArrayList listas)
            {
                foreach (int l in listas)
                    Console.WriteLine($" Lista {l}");
            }

            static void imprimirCola(Queue colas)
            {
                foreach (int c in colas)
                    Console.WriteLine($" Cola {c}");
            }
            static void imprimirPila(Stack pilas)
            {
                foreach (int p in pilas)
                    Console.WriteLine($" Pila {p}");
            }
            static void imprimirConcatenacion(ArrayList concatenacion)
            {
                foreach (int con in concatenacion)
                    Console.WriteLine($" Elementos {con}");
            }

        }
    }
}
