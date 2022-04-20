using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
// Programa para leer la altura de N personas y calcular la altura media. Calcular 
// cuántas personas tienen una altura superior a la media y cuántas tienen una 
// altura inferior a la media. El valor de N se pide por teclado y debe ser entero 
// positivo.


namespace Altura
{
    class Altura
    {
        static void Main(string[] args)
        {
            float suma =0.0F, promedio = 0.0F;

            Console.Write("Introduce la cantidad de personas: ");
            int personas = int.Parse(Console.ReadLine());

            int[] cantidad = new int [personas];
            float[] contador = new float [personas];

            for(int i = 0; i < cantidad.Length; i++){
                Console.Write($"Introduce una altura para la persona {i+1}: ");
                contador[i] = float.Parse(Console.ReadLine());
            }foreach(float j in contador){
                suma = j + suma;
            }
            promedio = suma/cantidad.Length;
            Console.WriteLine($"La media de la altura es: {promedio}");

            for(int i = 0; i < cantidad.Length; i++){
                if (contador[i] < promedio){
                    Console.WriteLine($"La persona: {i + 1} está por debajo del promedio");
                }
            }

            for(int i = 0; i < cantidad.Length; i++){
                if (contador[i] > promedio){
                    Console.WriteLine($"La persona: {i + 1} está por encima del promedio");
                }
            }

        }
    }
}