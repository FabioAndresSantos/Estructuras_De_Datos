using System;

namespace Ejer11sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, f = 0, contador = 0, contador1 = 0 ;
            int sw = 0, sw1=0, sw2=1;
            float acumulado = 0,acumulado1=0, SueldobaseF=1000000, SueldobaseH=900000;
            while (sw == 0)
            {
                Console.WriteLine("Ingrese el numero de empleados");
                int numempleados = int.Parse(System.Console.ReadLine());
                Console.WriteLine("Ingrese 1 para mujeres y 2 para hombres");
                int Tipoempleado = int.Parse(System.Console.ReadLine());
                if (Tipoempleado == 1)
                {
                    for (i = 1; i <= numempleados; i++)
                    {
                        Console.WriteLine("Ingrese el sueldo de la empleada");
                        int sueldoM = int.Parse(System.Console.ReadLine());
                        acumulado = acumulado + sueldoM;
                        if (sueldoM >= SueldobaseF)
                        {
                            Console.WriteLine($"El dinero total es {acumulado}");
                            contador++;
                            Console.WriteLine($"El numero de empleados que ganan mas de 1000000 son {contador}");
                        }
                    }
                }
                else if (Tipoempleado == 2)
                {
                    for (f = 1; f <= numempleados; f++)
                    {
                        Console.WriteLine("Ingrese el sueldo del empleado");
                        int sueldoH = int.Parse(System.Console.ReadLine());
                        acumulado1 = acumulado1 + sueldoH;
                        if (sueldoH <= SueldobaseH)
                        {
                            Console.WriteLine($"El dinero total es {acumulado1}");
                            contador1++;
                            Console.WriteLine($"El numero de empleados que ganan menos de 900000 son {contador1}");
                        }
                    }
                }
                Console.WriteLine("Si desea contiuar ingrese 0 en caso contrario ingrese 1");
                int Ciclo = int.Parse(System.Console.ReadLine());
                if (Ciclo == sw1)
                {
                    sw = 0;
                }
                if(Ciclo == sw2)
                {
                    sw++;
                }
            }
        }
    }
}
         







