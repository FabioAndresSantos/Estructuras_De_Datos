using System;

namespace Ejercicio1sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            String Al, A1, A2, A3, A4, A5, Ac;
            String No = "", Ma = "";
            int swich = 0, D1, Nu;
            Console.WriteLine("Nombre y apellido");
            A1 = Console.ReadLine();
            Console.WriteLine("Nombre y apellido");
            A2 = Console.ReadLine();
            Console.WriteLine("Nombre y apellido");
            A3 = Console.ReadLine();
            Console.WriteLine("Nombre y apellido");
            A4 = Console.ReadLine();
            Console.WriteLine("Nombre y apellido");
            A5 = Console.ReadLine();
            while (swich == 0)
            {
                Console.WriteLine("Elija a cual estudiante desea calificar");
                Al = Console.ReadLine();

                if (Al == A1 || Al == A2 || Al == A3 || Al == A4 || Al == A5)
                {
                    Console.WriteLine("Elija la materia a calificar tenga en cuenta que solo puede calificar entre");
                    Console.WriteLine("Matematicas,Español,Ingles y Fisica");
                    Ma = Console.ReadLine();
                }
                else
                    Console.WriteLine("Ha escrito algo incorrecto por favor intentelo de nuevo");
                swich = 0;
                        if (Ma == "matematicas" || Ma == "español" || Ma == "ingles" || Ma == "fisica")
                {
                    Console.WriteLine("escriba una calificacion de 0 a 100");
                    D1 = int.Parse(System.Console.ReadLine());
                    if (D1 >= 0 && D1 <= 100)
                    {
                        if (D1 < 50)
                            No = "Insuficiente";
                        if (D1 >= 50 && D1 < 69)
                            No = "Suficiente";
                        if (D1 >= 70 && D1 < 79)
                            No = "Bien";
                        if (D1 >= 79 && D1 < 89)
                            No = "Notable";
                        if (D1 >= 90 && D1 <= 100)
                            No = "Sobresaliente";

                        Console.WriteLine("La nota del estudiante {0} es {1} su desempeño en la materia es {2}", Al, D1, No);
                    }
                    else
                    {
                        Console.WriteLine("Ha escrito algo incorrecto por favor intentelo de nuevo");
                        swich = 0;
                    }
                }
                Console.WriteLine("digite 1 para reintentar o 2 para salir");
                Nu = int.Parse(System.Console.ReadLine());
                if (Nu == 1)
                {
                    swich = 0;
                }
                else if (Nu == 2)
                {
                    swich++;
                }
                else
                {
                    Console.WriteLine("Ha escrito algo incorrecto por favor intentelo de nuevo");
                    swich = 0;
                }
            }
        }
    }
}
