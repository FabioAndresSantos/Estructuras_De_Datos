using System;
using System.Collections;
using System.Collections.Generic;
// Escriba una rutina que reciba una PilaP de números enteros y mueva sus elementos a una nueva Pila,
// pero manteniendo  el orden de  salida  de los mismos. Al finalizar la PilaP no debe contener elementos.
namespace Ejercicio1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilaP = new Stack();
            Stack pilaP2 = new Stack();
            pilaP.Push(5);
            pilaP.Push(19);
            pilaP.Push(47);
            pilaP.Push(84);
            pilaP.Push(78);

            while (pilaP.Count>0){
                pilaP2.Push(pilaP.Pop);
            }

        }
    }
}
