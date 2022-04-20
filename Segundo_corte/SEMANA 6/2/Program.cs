using System;
using System.Collections;
namespace program
{
    class ejer2
    {
      Random rdn =new Random();
      ArrayList pila =new ArrayList();
      int cuadra=0,sum=0;
      public void carga ()
      {
          Console.WriteLine("digite la longitud de la lista");
          int lgd = int.Parse(Console.ReadLine());//se carga la longitud de la lista
          for (int i = 0; i < lgd; i++)
          { 
               //se generan los numeros aleatorios para la lista
              pila.Add(rdn.Next(0,51));
            
          }
          Console.WriteLine("los datos generados son:");
          foreach (int datos in pila)
          {//se muestran los datos al usuario 
             Console.Write($"{datos}, ");
          } 
           Console.WriteLine();
      }
      public void oper()
      {
          Console.WriteLine("el cuadrado de los datos es:");
          foreach (int dato in pila)
          {//se eleva el numero al cuadrado 
              cuadra=dato*dato;
              Console.Write($"{cuadra}, ");
               sum+=cuadra;//la variable "sum" va sumando los numeros de la lista al ser elevados al cuadrado
          }
          Console.WriteLine($"\nla suma de los cuadrados es de: {sum}");
      }

      static void Main(string []args)
      {
        ejer2 elementos =new ejer2();
        elementos.carga();
        elementos.oper();
      }  
    }
}