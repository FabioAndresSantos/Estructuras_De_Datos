using System;
using System.Collections;
using System.Collections.Generic;

namespace Punto_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
          Console.WriteLine("primera lista:");
           ArrayList Listnum1 = new ArrayList();
           Listnum1.Add(11);
           Listnum1.Add(13);
           Listnum1.Add(15);
           Listnum1.Add(17);
           Listnum1.Add(19);

           imprime(Listnum1);

          Console.WriteLine("segunda lista:");
           ArrayList Listnum2 = new ArrayList();
           Listnum2.Add(12);
           Listnum2.Add(14);
           Listnum2.Add(16);
           Listnum2.Add(18);
           Listnum2.Add(20);

           imprime(Listnum2);

           
           Console.WriteLine("la union de las listas es : ");
           Listnum1.AddRange(Listnum2);
           imprime(Listnum1);

        }
        static void imprime (ArrayList arreglo){
            foreach(int nums in arreglo)
            {
             Console.Write(" {0} ", nums);
           
            }
        }
    }
}
