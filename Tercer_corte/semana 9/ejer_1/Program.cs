using System;

namespace AplicacionBase
{
    public class Empleado
    {

        protected string nombre;
        protected double sueldo;   

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public double Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + Nombre);
            Console.WriteLine("Sueldo:" + sueldo);
            if (sueldo <= 3000)
            {
                Console.WriteLine("No debe pagar impuestos");
            }
            else if (sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Empleado persona1 = new Empleado();
            Console.WriteLine("Introduzca su nombre");
            string nombre = Console.ReadLine();
            persona1.Nombre = nombre;
            Console.WriteLine("Introduzca su sueldo");
            double sueldo = Double.Parse(Console.ReadLine());
            persona1.Sueldo = sueldo;

            Console.WriteLine();
            Console.WriteLine("Los datos de la persona son:");
            persona1.Imprimir();

            Console.ReadKey();
        }
    }
}