using System;
using System.Collections;
namespace AplicacionBase
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Stack PilaP = new Stack();
            Console.Write("Ingrese la dimensión de la pilaP: ");
            int dimensión = int.Parse(Console.ReadLine());
            for(int i = 0; i < dimensión; i++ )
            {
                float elemento;
                Console.Write($"Ingrese número flotante a la pila {i+1}: ");
                elemento = float.Parse(Console.ReadLine());
                
                PilaP.Push(elemento);
            }
           
            Console.WriteLine("PilaP:");
            imprimir(PilaP);
            Queue ColaP = new Queue ();
            Console.WriteLine("ColaP :");
            conversionACola(PilaP,ColaP);
            imprimir(ColaP);
        }
        static void imprimir (IEnumerable cola)
        {
            foreach (float numero in  cola)
                Console.Write($" {numero} |");
            Console.WriteLine("\n");
        }
        static void conversionACola(Stack pila, Queue cola)
        {
            foreach (float numero in  pila)
                cola.Enqueue(numero);
        }
    }
}
