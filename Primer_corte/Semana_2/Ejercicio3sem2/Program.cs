using System;

namespace Ejercicio3sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2, Res;
            int suma, resta, multiplicacion, division;
            Console.WriteLine("elija una operacion");
            Console.WriteLine("suma");
            Console.WriteLine("resta");
            Console.WriteLine("multipicacion");
            Console.WriteLine("division");
            string opcion = Console.ReadLine();
            Console.WriteLine("digite dos numeros naturales mayores a 100");
            N1 = int.Parse(Console.ReadLine());
            N2 = int.Parse(Console.ReadLine());
            if (N1 >= 100 && N2 >= 100)
            {
                switch (opcion)
                {
                    case "suma":
                        Res = N1 + N2;
                        Console.WriteLine("la suma de {0} y {1} es {2}", N1, N2, Res);
                        break;
                    case "resta":
                        Res = N1 - N2;
                        Console.WriteLine("la resta de {0} y {1} es {2}", N1, N2, Res);
                        break;
                    case "multiplicacion":
                        Res = N1 * N2;
                        Console.WriteLine("la multiplicacion de {0} y {1} es {2}", N1, N2, Res);
                        break;
                    case "division":
                        Res = N1 / N2;
                        Console.WriteLine("La division de {0} y {1} es {2}", N1, N2, Res);
                        break;
                    default:
                        Console.WriteLine("Ha elegido una opcion no valida");
                        break;
                }
            }
            else if (N1 < 100 || N2 < 100)
                Console.WriteLine("ha introducido un numero menor a 100 por favor vuelva a intentarlo");
        }
    }
}
