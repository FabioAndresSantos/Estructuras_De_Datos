using System;
using System.Collections;
//En la clase de estructuras de datos asiste un grupo de N alumnos.
//El profesor de dicha asignatura aplica 3 exámenes.
//Realice un programa que genere un array de N alumnos y sus 3 calificaciones y que calcule e imprima:
//oEl promedio de calificaciones de cada alumno.
//oEl promedio general de grupo.oEl número del estudiante que tuvo el mayor promedio de calificación.

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int EXAMENES_APLICADOS = 3;
            int estudiantes;
            int promedioMayor = 0;
            int totalPromedio = 0;
            int estudiantePromedioMayor = 0;
            int promedio = 0;
            int promedioGeneral;
            Console.WriteLine("Ingrese la cantidad de estudiantes: ");
            estudiantes = int.Parse(Console.ReadLine());
            int[,] clase_Estructura_Datos = new int[estudiantes, EXAMENES_APLICADOS];
            for (int e = 0; e < estudiantes; e++)
            {
                Console.WriteLine($"Ingrese las calificaciones del estudiante {e + 1}: ");
                for (int a = 0; a < EXAMENES_APLICADOS; a++)
                {
                    Console.Write($"Exámen {a + 1 } = ");
                    clase_Estructura_Datos[e, a] = int.Parse(Console.ReadLine());
                    promedio += clase_Estructura_Datos[e, a];
                }
                promedio = promedio / 3;
                totalPromedio += promedio;
                if (promedio > promedioMayor)
                {
                    promedioMayor = promedio;
                    estudiantePromedioMayor = e + 1;
                }
                Console.WriteLine($"El promedio del estudiante {e + 1} es de: {promedio}");
                promedio = 0;
            }
            promedioGeneral = totalPromedio / estudiantes;
            Console.WriteLine($"El promedio general del grupo es: {promedioGeneral}");
            Console.WriteLine($"El mayor promedio es del estudiante {estudiantePromedioMayor} con {promedioMayor}");
        }   
    }
}
