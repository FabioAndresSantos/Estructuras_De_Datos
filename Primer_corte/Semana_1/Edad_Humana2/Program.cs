using System;

namespace Edad_Humana2
{
    class Program
    {
        private const double V = 21;
        private const Double V1 = 10.5;

        static void Main(string[] args)
        {
            float EdadHumana1;
            float Edad1 = (float)V;
            float Edad1_1 = (float)V1;
            float EdadC;
            float Edad2 = 4;

            Console.WriteLine("Ingrese la edad del canino");
            EdadC = int.Parse(System.Console.ReadLine());
            if (EdadC == 1)
            {
                EdadHumana1 = Edad1_1;
                Console.WriteLine("La edad del canino en años humanos es: " + EdadHumana1);
            }
                if (EdadC == 2)
                {
                    EdadHumana1 = Edad1;
                    Console.WriteLine("La edad del canino en años humanos es:" + EdadHumana1); 
                }
            
            if (EdadC >= 3)
            { 
                EdadC =(( EdadC -2)* Edad2);
                EdadHumana1 = EdadC+Edad1;
                Console.WriteLine("La edad del canino en años humanos es:" + EdadHumana1);
            }            
        }
    }
} 