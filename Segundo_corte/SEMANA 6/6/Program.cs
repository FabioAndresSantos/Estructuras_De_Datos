using System;
using System.Collections;

/*
    GROUP MEMBERS
        Roa Ruiz Maria Camila
        Barbosa Fierro Luis Esteban
        Cardona Acuña David Esteban
        González Casilimas Daniel Stevan
    
    SHIFT
        diurnal
    GROUP
        63102C / 239-2A */

namespace EJERCICIO_6
{
    class Ejer6
    { 
        ArrayList pila1= new ArrayList();
        ArrayList pila2= new ArrayList();
        Random rdn = new Random();

        public void carga()
        {
          Console.Write("digite la longitud de la pila 1: ");
          int lgd=int.Parse(Console.ReadLine());//se le da la longitud al arraylist
          for (int i = 0; i < lgd; i++)
          {
              pila1.Add(rdn.Next(0,200));
          }
          Console.WriteLine("la pila 1 contiene los datos: ");
          foreach (int datos in pila1)
          {
            Console.Write($"{datos}, ");//se muestran los datos de la pila1
          }
          
        }
        public void parte2()
        {
          pila2.AddRange(pila1);//Se pasan los copian los datos de la pila1 a la pila2

          pila2.Reverse();//coge los datos de atras hacia adelante

          pila1.Clear();//se eliminan los datos de la pila1
          Console.WriteLine("\nlos datos de la pila 2 quedarian: ");
          foreach (int dato in pila2)
          {
              Console.Write($"{dato}, ");
          }
          Console.WriteLine("\nla pila 1 queda vacia");
          foreach (int datos in pila1)
          {//se demuestra que la pila 1 quedo vacia
           Console.Write($"{datos}, ");   
          }

        }
        static void Main(string[] args)
        {
            //Programa en el que se pasa Pila1 a la Pila2 con los elemnetos invertidos. Y al final la primera Pila no debe tener información.
          Ejer6 pilas = new Ejer6 ();
          pilas.carga();
          pilas.parte2();
           
        }
    }
}