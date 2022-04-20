using System;

namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {

            int[] numeros = new int [100];
            int suma=0, promedio=0;
            for(int contador=0; contador < numeros.Length; contador++){
                suma = contador + suma;
            }
            promedio = suma/100;
            Console.WriteLine($"La suma es {suma}");
            Console.WriteLine($"el promedio es {promedio}");
        }
    }
}
