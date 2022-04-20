using System;
using System.Collections;
using System.Collections.Generic;

namespace program
{
    class ejer2
    {
        Random rdn =new Random();
        Stack pila1=new Stack();
        int sum=0,cu=0;
        public void carga()
        {
            //se digita la longitud
            Console.WriteLine("digite la longitud de la pila");
            int longitud=int.Parse(Console.ReadLine());
            for (int i = 0; i < longitud; i++)
            {
                pila1.Push(rdn.Next(1,10));
            }
            Console.WriteLine("los elementos de la pila son: ");
            foreach (int n in pila1)
            {  //se muestran los elementos de la pila
                Console.Write($"|{n}| ");
            }
        }
        public void oper()
        {  //se opera la pila al cuadrado
            Console.WriteLine("\nlos cuadrados de la pila son: ");
            foreach (int n in pila1)
            {
              cu=n+n;
              Console.Write($"|{cu}| ");
              sum+=cu;
            }
            Console.WriteLine($"\nla suma de los cuadrados es: {sum}");
        }
      static void Main(string []agrs)
      {
        ejer2 run =new ejer2();
        run.carga();
        run.oper();

      }
    }
}