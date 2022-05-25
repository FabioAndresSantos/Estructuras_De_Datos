using System;

namespace AplicacionBase
{
    public class Operacion
    {

        protected int valor1;
        protected int valor2;
        protected int valor3;
        protected double valor4;
        protected int resultado;

        public int Valor1
        {
            set
            {
                valor1 = value;
            }
            get
            {
                return valor1;
            }
        }
        public int Valor2
        {
            set
            {
                valor2 = value;
            }
            get
            {
                return valor2;
            }
        }


        public int Valor3
        {
            set
            {
                valor3 = value;
            }
            get
            {
                return valor3;
            }
        }
        public double Valor4
        {
            set
            {
                valor4 = value;
            }
            get
            {
                return valor4;
            }
        }

        public int Resultado
        {
            protected set
            {
                resultado = value;
            }
            get
            {
                return resultado;
            }
        }
    }


    public class Suma : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 + Valor2;
        }
    }


    public class Resta : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 - Valor2;
        }
    }
    public class multiplicacion : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 * Valor2;
        }
    }
    public class division : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 / Valor2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Suma suma1 = new Suma();
            suma1.Valor1 = 10;
            suma1.Valor2 = 7;
            suma1.Operar();
            Console.WriteLine("La suma de " + suma1.Valor1 + " + " + suma1.Valor2 + " = " + suma1.Resultado);

            Resta resta1 = new Resta();
            resta1.Valor1 = 8;
            resta1.Valor2 = 4;
            resta1.Operar();
            Console.WriteLine("La resta de " + resta1.Valor1 + " - " + resta1.Valor2 + " = " + resta1.Resultado);

            multiplicacion multiplicacion1 = new multiplicacion();
            multiplicacion1.Valor1 = 9;
            multiplicacion1.Valor2 = 78;
            multiplicacion1.Operar();
            Console.WriteLine("La multiplicacion  de " + multiplicacion1.Valor1 + " * " + multiplicacion1.Valor2 + " = " + multiplicacion1.Resultado); 

            division division1 = new division();
            division1.Valor1 = 78;
            division1.Valor2 = 6;
            division1.Operar();
            Console.WriteLine("La division de " + division1.Valor1 + " / " + division1.Valor2 + " = " + division1.Resultado);

            Console.ReadKey();
        }
    }
}