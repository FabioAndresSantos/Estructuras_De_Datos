using System;
using System.Collections;
using System.Collections.Generic;
// Escriba una rutina que reciba dos PilasP1 y P2 de números enteros y proceda a intercambiar
// sus elementos,pero manteniendo el orden de salida de los elementos. Al finalizar la rutina,
// la PilaP1 tendrá los elementos de laPilaP2 y esta a su vez tendrá los elementos delaPilaP1.
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilaP = new Stack();
            Stack pilaP2 = new Stack();
            Stack pilaP3 = new Stack();
            Stack pilaP4 = new Stack();

            pilaP.Push(1);
            pilaP.Push(2);
            pilaP2.Push(3);
            pilaP2.Push(4);

            while (pilaP.Count>0){
                pilaP3.Push( (int) pilaP.Pop());
            }

            while (pilaP2.Count>0){
                pilaP4.Push( (int) pilaP2.Pop());
            }

            while (pilaP3.Count>0){
                pilaP2.Push( (int) pilaP3.Pop());
            }

            while (pilaP4.Count>0){
                pilaP.Push( (int) pilaP2.Pop());
            }
        }
    }
}
