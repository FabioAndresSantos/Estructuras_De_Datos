using System;
using System.Collections;
using System.Collections.Generic;
namespace program
{
    class ejer8
    { 
        ArrayList p = new ArrayList();
        ArrayList p1 = new ArrayList();
        ArrayList p2 = new ArrayList();
        Random rdn =new Random();
        public void carga()
        {
            Console.WriteLine("digite el tamaño de las pilas");
            int t=int.Parse(Console.ReadLine());
           
            for (int i = 0; i < t; i++)
            {
                p1.Add(rdn.Next(1,10));
                p2.Add(rdn.Next(10,20));
            }
            Console.WriteLine("la pila 1 tiene los elementos: ");
            foreach (int n in p1)
            {
                Console.Write($"{n}| ");
            }
            Console.WriteLine("\nla pila 2 tiene los elementos: ");
            foreach (int n in p2)
            {
                Console.Write($"{n}| ");
            }
            Console.WriteLine();
        }
        public void oper()
        {
          p=p1;
          p1=p2;
          p2=p;
          Console.WriteLine("la pila 1 quedo con los elementos: ");
            foreach (int n in p1)
            {
                Console.Write($"{n}| ");
            }
            Console.WriteLine("\nla pila 2 quedo con los elementos: ");
            foreach (int n in p2)
            {
                Console.Write($"{n}| ");
            }
        }



        static void Main(string []args)
        {
         ejer8 res = new ejer8();
         res.carga();
         res.oper();
        }
    }
}