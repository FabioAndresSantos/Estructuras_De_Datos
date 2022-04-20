using System;
using System.Collections;
//Escriba un programa que reciba la dirección del primer elemento de una lista/pila/cola simple
//de números enteros y devuelva un apuntador al elemento donde exista el número.
//<x>.Este número es recibido por el método.SedeberetornarNULLsielvalor
//de<x>noseencuentraenlalista/pila/cola.

namespace Arraylist3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaObjetos = new ArrayList();
            listaObjetos.Add(10);
            listaObjetos.Add(44);
            listaObjetos.Add(7);
            imprimir(listaObjetos);
      
            Console.WriteLine($"El 10 se encuentra en la posicion {1}",listaObjetos.IndexOf(10));
        

        static void imprimir(ArrayList arreglo)
        {
            foreach (int l in arreglo)
                Console.Write($" {l} ");
            Console.WriteLine("\n-----------");


        }
      }
  }
}
