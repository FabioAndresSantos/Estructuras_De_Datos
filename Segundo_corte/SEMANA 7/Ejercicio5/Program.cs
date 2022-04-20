using System;
using System.Collections;
using System.Collections.Generic;
// Escriba una rutina que reciba una PilaP de números enteros y devuelva una copia exacta de la misma.
// Esde destacar que la PilaP no debe sufrir ningún tipo de cambio o alteración.
namespace Ejercicio5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilaP = new Stack();
            int num;

            pilaP.Push(1);
            pilaP.Push(2);
            pilaP.Push(3);

            for (byte i = 0; i < 2; i++)
            {
                num = (int)pilaP.Pop();
                Console.WriteLine(num);
            }
        }
    }
}
