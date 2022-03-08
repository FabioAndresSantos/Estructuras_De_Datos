using System;


namespace calificaciones
{
    class program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, Ma, Me, Res;
            Console.WriteLine("Digite su primera calificacion");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite su segunda calificacion");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite su tercera calificacion");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite su cuarta calificacion");
            n4 = double.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3 && n1 > n4)
            {
                Res = ((n1 + n2 + n3 + n4) / 4);
                Ma = n1;
                if (n2 < n3 && n2 < n4)
                {
                    Me = n2;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
                else if (n3 < n2 && n3 < n4)
                {
                    Me = n3;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
                else if (n4 < n2 && n4 < n3)
                {
                    Me = n4;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
                else if (n2 == n3 && n4 == n2)
                {
                    Me = n2;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
            }
            else if (n2 > n1 && n2 > n3 && n2 > n4)
            {
                Res = ((n1 + n2 + n3 + n4) / 4);
                Ma = n2;
                if (n1 < n3 && n1 < n4)
                {
                    Me = n1;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
                else if (n3 < n1 && n3 < n4)
                {
                    Me = n3;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
                else if (n4 < n1 && n4 < n3)
                {
                    Me = n4;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
                else if (n1 == n3 && n4 == n1)
                {
                    Me = n4;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
            }
            else if (n3 > n2 && n3 > n1 && n3 > n4)
            {
                Res = ((n1 + n2 + n3 + n4) / 4);
                Ma = n3;
                if (n2 < n1 && n2 < n4)
                {
                    Me = n2;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
                else if (n1 < n2 && n1 < n4)
                {
                    Me = n1;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
                else if (n4 < n2 && n4 < n1)
                {
                    Me = n4;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
                else if (n1 == n2 && n4 == n1)
                {
                    Me = n4;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
            }
            else if (n4 > n2 && n4 > n1 && n4 > n3)
            {
                Res = ((n1 + n2 + n3 + n4) / 4);
                Ma = n4;
                if (n1 < n2 && n1 < n3)
                {
                    Me = n1;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
                else if (n2 < n1 && n2 < n3)
                {
                    Me = n2;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
                else if (n3 < n2 && n3 < n1)
                {
                    Me = n3;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }
                else if (n1 == n2 && n3 == n1)
                {
                    Me = n1;
                    Console.WriteLine("El promedio del estudiante es {0}", Res);
                    Console.WriteLine("La mayor nota es {0}", Ma);
                    Console.WriteLine("La menor nota es {0}", Me);
                }

            }
        }
    }
}
