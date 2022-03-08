using System;
using System.Text;
namespace Ejercicio7sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = ""; //Crea un programa que leauna frase que ingrese el usuario, el programa debe indicar la cantidad de vocales,cantidad de números y cantidad de consonantes que tiene la frase
            int c, vocales=0, consonantes=0, cantidadnum=0;
            char j;
            Console.WriteLine("Ingrese una frase u oración");
            frase = Console.ReadLine();
            for (c = 0; c < frase.Length; c++)
            {
                j = frase[c];
                int g = char.ToLower(j);
                if (g == 'a' || g == 'e' || g == 'i' || g == 'o' || g == 'u')

                {
                    vocales++;
                }
                else if (g == 'b' || g == 'c' || g == 'd' || g == 'f' || g == 'g' || g == 'h' || g == 'j' || g == 'k' || g == 'l' || g == 'n' ||
                    g == 'm' || g == 'ñ' || g == 'p' || g == 'q' || g == 'r' || g == 's' || g == 't' || g == 'v' || g == 'w' || g == 'x' ||
                    g == 'y' || g == 'z')
                {
                    consonantes++;
                }
                else if( g=='0' || g=='1' || g=='2' | g=='3'| g=='4'| g=='5'| g=='6'| g=='7' || g=='8'| g=='9')
                {
                    cantidadnum++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("La frase tiene "  + vocales +  ":vocales");
            Console.WriteLine("La frase tiene "  + consonantes +  ":consonantes");
            Console.WriteLine("La frase tiene "  + cantidadnum +  ":cantidad de numeros");
            Console.WriteLine("La frase tiene "  +frase.Length +  ":Caracteres");
            Console.ReadKey();   
        }
    }
}
