using System;
using System.Collections;


namespace EJERCICIO_12
{
    class Program
    {
        static void Main(string[] args)
        {
                     Queue Cola = new Queue();
            Random DatosAleatorios = new Random();

            int Longitud;

            Console.WriteLine("Ingrese la longitud de la cola");
            Longitud = int.Parse(Console.ReadLine());

            for (int i = 0; i < Longitud; i++)
            {
                Cola.Enqueue(DatosAleatorios.Next(0,100));
            }

            Console.WriteLine("");
            Console.WriteLine("Contenido actual de la Cola");

            foreach (int c in Cola)
            {
                Console.WriteLine($"--  {c}  --");
                Console.WriteLine("---------");
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Se hará una copia de la cola para pasarla a una Pila");

            int[] Pila = new int[Cola.Count];

            Cola.CopyTo(Pila,0);

            Console.WriteLine("");
            Console.WriteLine("Contenido de la Pila");

            foreach (int p in Pila)
            {
                Console.WriteLine($"--  {p}  --");
                Console.WriteLine("---------");
                Console.WriteLine("");
            }

            Console.WriteLine("Ingrese 1 si desea eliminar los datos de la Cola");
                        int Respuesta = 0;
            Respuesta = int.Parse(Console.ReadLine());

            if (Respuesta == 1)
            {
                Cola.Clear();

                Console.WriteLine("");
                foreach (int c in Cola)
                {
                    Console.WriteLine($"--  {c}  --");
                    Console.WriteLine("---------");
                    Console.WriteLine("");
                }

                Console.WriteLine("elemetos de la cola eliminados");
            }

            else
            {
                Console.WriteLine("no se elimino la primera fila");
            }
        }
    }
}