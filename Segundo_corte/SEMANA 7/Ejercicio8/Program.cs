using System;
using System.Collections;
using System.Collections.Generic;
namespace program
{
    class ejer8
    {
        Queue cola = new Queue();
        Random rdn = new Random();
        public void carga()
        {
            Console.WriteLine("Digite la longitud de la cola");
            int longitud=int.Parse(Console.ReadLine());
            for (int i = 0; i < longitud; i++)
            {
               cola.Enqueue(rdn.Next(1,10)); 
            }
            Console.WriteLine("los numeros de la cola son:");
            
          foreach (int n in cola)
          {
              Console.Write($"|{n}| ");
          }
          Console.WriteLine();
           int [] pila = new int [cola.Count];
            cola.CopyTo(pila,0);

          Console.WriteLine();
          Console.WriteLine("los datos de la pila son:");
          foreach (int n in pila)
          {
              Console.Write($"|{n}| ");
          }
          Console.WriteLine();
          cola.Clear();
          Console.WriteLine("la cola no tiene elementos");
          
        }
        static void Main(string[]args)
        {
           ejer8 datos= new ejer8();
          datos.carga();
        }
    }
}
