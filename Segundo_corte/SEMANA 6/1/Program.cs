// Escriba un programa que inserte valores ordenadamente en una lista. La lista/pila/cola
// debe almacenar números enteros. El programa debe leer una secuencia de números
// enteros de la entrada hasta que se ingrese el número cero.
using System;
using System.Collections;
namespace Aplicacionbase
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList datos = new ArrayList();
            int sw = 0;
            int elemento;
            Console.WriteLine("Ingrese elementos enteros. Para parar digite el numero 0: ");
            while (sw == 0){
                Console.WriteLine("Ingrese elemento: ");
                elemento = int.Parse(System.Console.ReadLine());
                datos.Add(elemento);
                if (elemento == 0){
                    sw = 1;
                }
            }
        }
    }
}

