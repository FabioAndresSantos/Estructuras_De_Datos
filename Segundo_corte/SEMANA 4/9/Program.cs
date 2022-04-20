using System;
using System.Linq;
using System.Collections;

namespace Ejercicio9
{
    //Programaque muestra el número de apuestas que son necesarias para que se acierten 5números dados en una lotería
    class Program
    {
        int[] vector;
        int numerosGanarLoteria, numerosGanarLoteria1, numerosGanarLoteria2, numerosGanarLoteria3, numerosGanarLoteria4;
        int numeroPosibilidades;
        int contadorApuestas;
        int limiteIntentos;
        public void pedirDatos()
        {
           
                Console.WriteLine("Ingrese los numeros de loteria de entre 0 y 1000");
                numerosGanarLoteria = int.Parse(System.Console.ReadLine());
                Console.WriteLine("Ingrese los numeros de loteria de entre 0 y 1000");
                numerosGanarLoteria1 = int.Parse(System.Console.ReadLine());
                Console.WriteLine("Ingrese los numeros de loteria de entre 0 y 1000");
                numerosGanarLoteria2 = int.Parse(System.Console.ReadLine());
                Console.WriteLine("Ingrese los numeros de loteria de entre 0 y 1000");
                numerosGanarLoteria3 = int.Parse(System.Console.ReadLine());
                Console.WriteLine("Ingrese los numeros de loteria de entre 0 y 1000");
                numerosGanarLoteria4 = int.Parse(System.Console.ReadLine());
            
            Console.WriteLine("Cuantos intentos desea realizar");
            limiteIntentos = int.Parse(System.Console.ReadLine());
            vector = new int[limiteIntentos];
           }
    
        public void operarVector()
        {
            for (int f = 0; f < vector.Length; f++)
            {
                Random posibilidades = new Random();
                numeroPosibilidades = posibilidades.Next(0, 1001);
                Console.WriteLine("El numero es: " + numeroPosibilidades);
                contadorApuestas++;
                if (numeroPosibilidades == numerosGanarLoteria || numeroPosibilidades==numerosGanarLoteria1
                    ||numeroPosibilidades==numerosGanarLoteria2 || numeroPosibilidades==numerosGanarLoteria3
                    ||numeroPosibilidades==numerosGanarLoteria4)
                {
                    Console.WriteLine("El numero de loteria es: " + numeroPosibilidades);
                    Console.WriteLine($"Se necesitan {contadorApuestas} intentos para poder ganar con algun numero de la loteria");
                    
                }
              
            }
        }
            static void Main(string[] args)
            {
                Program loteria = new Program();
                loteria.pedirDatos();
                loteria.operarVector();
           }
     }
}


