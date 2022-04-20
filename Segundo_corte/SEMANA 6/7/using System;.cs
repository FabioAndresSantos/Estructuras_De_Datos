using System;
using System.Collections;


namespace EJERCICIO_12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {

            ArrayList Pila = new ArrayList();
            Random DatosAleatorios = new Random();
            int Longitud;
            int Respuesta;

            Console.WriteLine("Ingrese la longitud de la lista");
            Longitud = int.Parse(Console.ReadLine());

            for (int i = 0; i < Longitud; i++)
            {
                Pila.Add(DatosAleatorios.Next(0,100));
            }

            Pila.Sort();

            Console.WriteLine("");
            Console.WriteLine("lsita actual");
            Imprimir(Pila);

            ArrayList NuevaPila = new ArrayList();

            Console.WriteLine("");
            Console.WriteLine("datos en nueva lista");

            NuevaPila.AddRange(Pila);

            Console.WriteLine("");
            Console.WriteLine("Contenido lista nueva");
            Imprimir(NuevaPila);

            Console.WriteLine("Ingrese 1 si desea eliminar los datos de la primera");
            Respuesta = int.Parse(Console.ReadLine());

            if (Respuesta == 1)
            {
                Pila.Clear();

                Console.WriteLine("");
                
                foreach (int c in Pila)
                {
                    Console.WriteLine($" [{c}] ");
                }

                Console.WriteLine("se elimino la lista");
            }

            else
            {
                Console.WriteLine("no se elimino la lista");
            }
            
        }

        static void Imprimir (ArrayList Arreglo)
        {
            foreach (int n in Arreglo)
            {
                Console.WriteLine($" [{n}] ");
            }
        }
    }
}