using System;
using System.Collections;
using System.Collections.Generic;
 //escriba una rutina que reciba dos pilas p1 y p2 de numeros flotantes y apile las mismas en una nueva pila resultante
 //es de destacar que las pilas recibidas no deberan sufrir cambios o alteraciones
namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila1 = new Stack();
            Stack pila2 = new Stack();
            Stack pila3 = new Stack();
            pila1.Push(8.8);
            pila1.Push(10.5);
            pila1.Push(12.6);

            pila2.Push(15.2);
            pila2.Push(14.5);
            pila2.Push(47.1);

            while (pila1.Count > 0)
            {
                double pilasTotal = 0;
                pilasTotal =(double)pila1.Pop();
                Console.WriteLine($" elementos de la cola número uno: {pilasTotal}");
                pila3.Push(pilasTotal);
            }
            Console.WriteLine(" ");
            while (pila2.Count > 0)
            {
                double pilaTotal2 = 0;
                pilaTotal2 = (double)pila2.Pop();
                Console.WriteLine($" elemento de la cola número dos: {pilaTotal2}");
                pila3.Push(pilaTotal2);
            }
            Console.WriteLine(" ");
           
            imprimirPilas(pila3);
           
            
            
        static void imprimirPilas(Stack pila1)
            {
                foreach (double n in pila1)
                    Console.WriteLine($"el elemento de la pila es {n}");
            }
        }
    }
}
