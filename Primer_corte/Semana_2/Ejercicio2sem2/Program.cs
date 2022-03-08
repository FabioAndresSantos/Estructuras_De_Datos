using System;

namespace Ejercicio2sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sp = 0, Si = 0, p1 = 0, p2 = 0;
            string num;
            int[] Numero = new int[10];
            Console.WriteLine("ingrese 10 numeros sean positivos o negativos");

            for (int i = 0; i < 10; i++)
            {
                num = Console.ReadLine();
                Numero[i] = int.Parse(num);

            }
            for (int i = 0; i < 10; i++)
            {

                if ((Numero[i] % 2) == 0)
                {
                    p1++;
                    Sp = Sp + Numero[i];

                }
                else
                {
                    p2++;
                    Si = Si + Numero[i];

                }

            }
            p1 = Sp / p1;
            Console.WriteLine("la suma de los numeros pares es de {0} el promedio es de {1}", Sp, p1);
            p2 = Si / p2;
            Console.WriteLine("La suma de los numeros impares es de {0} el promedio es de {1}", Si, p2);

        }
    }
}
