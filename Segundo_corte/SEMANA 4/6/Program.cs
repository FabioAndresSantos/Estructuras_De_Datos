using System;

namespace Ejercicio6
{
    //Crea un array de números de un tamaño pasado por teclado, el array contendrá números aleatorios entre 1 y 300 y
    //mostrar aquellos números que acaben en un dígito que nosotros le indiquemos por teclado
    //(debes controlar que se introduce un numero correcto)
    //, estos deben guardarse en un nuevo array.
    class Program
    {
        static void Main(string[] args)
        {
            int[] Matriz;
            int longitudVector;
            int longitudColumna;
            int ultimoDigito;
            Console.WriteLine("Ingrese el tamaño del vector");
            longitudVector = int.Parse(System.Console.ReadLine());
            Matriz = new int[longitudVector];
            Console.WriteLine("Ingrese el ultimo digito que desea ver");
            ultimoDigito = int.Parse(System.Console.ReadLine());
            int f;
            int c = 0;
            Random numeroAleatorio = new Random();
            Console.WriteLine("La matriz resultante es");

            for (f = 0; f < Matriz.Length; f++)
            {
                    Matriz[f] = numeroAleatorio.Next(1, 301);
                    Console.Write("   [" + Matriz[f] + "]");
                    Console.WriteLine();
              
                
                    if (Matriz[f] % 10 == ultimoDigito)
                    {

                        Console.WriteLine("El numero es: [" + Matriz[f] + "]");
                    }
                
            
            }

           
        }


        }
    }

    

    

