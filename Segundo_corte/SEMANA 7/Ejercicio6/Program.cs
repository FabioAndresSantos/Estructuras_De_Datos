using System;
using System.Collections;
namespace program
{
    class ejer6
    {
        Stack pila =new Stack();
        Stack pila1=new Stack();
        
        Random rdn = new Random();
        public void carga()
        {
              pila.Push(1.0);
              pila.Push(2.6);
              pila.Push(3.6);
          
          Console.WriteLine("los numero de la pila son:");
          foreach (double n in pila)
          {
              Console.Write($"|{n}| ");
          }
          Console.WriteLine();
          double [] pila1 = new double [pila.Count];
          pila.CopyTo(pila1,0);
          Array.Reverse(pila1);
          Console.WriteLine("los datos de la pila 1 son");
          foreach (double n in pila1)
          {
            Console.Write($"|{n}| ");
          }
        }
        static void Main(string[]args )
        {
          ejer6 datos= new ejer6();
          datos.carga();
        }
    }
}