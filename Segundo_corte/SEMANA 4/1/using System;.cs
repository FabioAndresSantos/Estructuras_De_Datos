using System;

namespace Punt_1
{
    class Program
    {

      private int[] numeros;
       int numeros2 = 0;

        public void Captura(){
            numeros = new int[3];
           
            for( int f = 0; f < 3; f++){
              Console.WriteLine($"Por favor ingrese el numero  {f+1}"); 
              numeros[f]= int.Parse(Console.ReadLine());
            }
           Console.WriteLine("Por favor ingrese el numero con el que se haran las operaciones");
           numeros2 = int.Parse(Console.ReadLine()); 
        }

        public void Multiplicacion(){
            float division = 0.0f;
            for(int k = 0; k < 3; k++){
            division = numeros[k]/numeros2;
            Console.WriteLine($"El indice es: {k+1} su valor es: {numeros[k]} -> La multiplicacion por {numeros2} es: {numeros[k] * numeros2}");  
            Console.WriteLine($"El indice es: {k+1} su valor es: {numeros[k]} -> La division por {numeros2} es: {division}");
         }
        }
        


        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.Captura();
            pv.Multiplicacion();
        }
    }
}
