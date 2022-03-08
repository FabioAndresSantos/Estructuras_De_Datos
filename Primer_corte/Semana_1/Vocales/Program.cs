using System;
namespace VentasABC
{
    public class Program
    {
        static void Main(string[] args)
        {
            char c;

            System.Console.WriteLine("Por favor ingrese un caracter, tiene que ser vocal, letra minuscula y alfabético");
            c = char.Parse(System.Console.ReadLine());
            if (char.IsUpper(c))
            {
                Console.WriteLine("No tiene que llevar mayuscula");
            }
            else if (char.IsDigit(c))
            {
                Console.WriteLine("No tiene que ser del alfaberico");
            }
            else if (c != 'a' || c != 'e' || c != 'i' || c != 'o' || c != 'u')
            {
                Console.WriteLine("Bien hecho!");
            }
            else
            {
                Console.WriteLine("Tiene que ser una vocal");
            }
        }
    }
}

