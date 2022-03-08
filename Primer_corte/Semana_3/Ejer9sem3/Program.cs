using System;
using System.Text;

namespace Ejer9sem3
{
    class Program
    {
        static void Main(string[] args)
        {
             int sw=0;
            
            Console.WriteLine("Ingrese primer lado del triangulo");
            int lado1 =int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese segundo lado del triangulo");
            int lado2 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese tercer lado del triangulo");
            int lado3 = int.Parse(System.Console.ReadLine());
            while (sw==0)
            {
                if (lado1 == lado2 && lado1>lado3 || lado2==lado3 && lado2>lado3 || lado1==lado3 && lado1>lado2  )
                {
                    Console.WriteLine("El triangulo es isósceles");
                    sw++;
                }
                if(lado1==lado2 && lado1 == lado3)
                {
                    Console.WriteLine("El triangulo es equilátero");
                    sw++;
                }
                if( lado1<lado2 && lado2<lado3 || lado1>lado2 && lado2 > lado3 || lado3>lado1 && lado3>lado2)
                {
                    Console.WriteLine("El triangulo  es escaleno");
                    sw++;
                }
            }
            {
                  
            }
        }

     }
    

