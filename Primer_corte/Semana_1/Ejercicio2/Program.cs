using System;

namespace Peliculas
{
    class program
    {
        static void Main(string[] args)
        {
            int p1, p2, p3;
            int res;
            Console.WriteLine("digte el valor de la primera pelicula");
            p1 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite el valor de la segunda pelicula");
            p2 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite el valor de la tercera pelicula");
            p3 = int.Parse(System.Console.ReadLine());

            if (p1 > 0 && p2 > 0 && p3 > 0)
            {
                if (p1 > p2 && p1 > p3)
                {
                    p1 = 0;
                    res = p2 + p3;
                    Console.WriteLine("Ha llevado tres peliculas con el valor de dos, el total a pagar es de: {0}.", res);
                }
                else if (p2 > p1 && p2 > p3)
                {
                    p2 = 0;
                    res = p1 + p3;
                    Console.WriteLine("Ha llevado tres peliculas con el valor de dos, el total a pagar es de: {0}.", res);
                }
                else if (p3 > p1 && p3 > p2)
                {
                    p3 = 0;
                    res = p2 + p1;
                    Console.WriteLine("Ha llevado tres peliculas con el valor de dos, el total a pagar es de: {0}.", res);
                }
                else
                {
                    res = p1 + p2 + p3;
                    Console.WriteLine("No aplica el descuento el precio de sus peliculas es {0}", res);
                }
            }

            else
            {
                Console.WriteLine("Ha ocurrido un error por favor vuelva a intentarlo");
            }
        }
    }
}