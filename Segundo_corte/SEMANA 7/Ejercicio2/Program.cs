using System;
using System.Collections;

namespace program
{
    class ejer2_1
    {
        Stack pila1 = new Stack();
        Stack pila2 = new Stack();
        Random rdn =new Random();
        
        public void cargar()
        {
         Console.WriteLine("digite la longitud de la pila");
         int longitud=int.Parse(Console.ReadLine());
         for (int i = 0; i < longitud; i++)
         {
           pila1.Push(rdn.Next(1,10));
         }
         Console.WriteLine("los numero generados son:");
         foreach (int n in pila1)
         {
             Console.Write($"|{n}| ");
         }
         Console.WriteLine();
        int [] pila2 = new int [pila1.Count];
            pila1.CopyTo(pila2,0);
            Array.Reverse(pila2);
            pila1.Clear();
            Console.WriteLine("los numero invertidos son:");
         foreach (int n in pila2)
         {
          Console.Write($"|{n}| ");   
         }
        }
        static void Main(string []args)
        {
          ejer2_1 dato=new ejer2_1();
          dato.cargar(); 
        }
    }
}
