using System;

namespace RaizCuadrada
{
    class Raiz
    {
        static void Main(string[] args)
        {
            double numero, n;
            Console.Write("Ingresa el numero: ");
            numero = double.Parse(Console.ReadLine());
            if (numero >= 0)
            {
                n = Math.Sqrt(numero);

                Console.WriteLine("el valor de la raiz es : " + n);
                Console.WriteLine();
            }

            else

            {
                n = Math.Sqrt(-numero);
                Console.WriteLine(" no es valido el dato ingresado digite un numero positivo");
            }

        }
    }
}
