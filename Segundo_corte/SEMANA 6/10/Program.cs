// 10. Escriba una rutina que reciba una Pila P de números flotantes y devuelva una nueva Pila,
// pero con los elementos invertidos, es decir el último de la Pila P, pasará a ser el primero
// de la nueva Pila Es de destacar que la Pila P no debe sufrir ningún tipo de cambio o
// alteración.
using System;
using System.Collections;
namespace Aplicacionbase
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList datos = new ArrayList();
            ArrayList datos2 = new ArrayList();
            int limite = 0;
            int elemento;
            Console.WriteLine("Ingrese cuantos elementos va a ingresar: ");
            limite = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < limite; i++){
                Console.WriteLine($"Ingrese el elemento {i+1}: ");
                elemento = int.Parse(System.Console.ReadLine());
                datos.Add(elemento);
            }
            Console.WriteLine("1ra lista: ");
            foreach (int n in datos){
                Console.WriteLine(n);
            } 
            datos2.AddRange(datos);
            datos2.Reverse();
            Console.WriteLine("2da lista: ");
            foreach (int n in datos2){
                Console.WriteLine(n);
            } 
        }
    }
}