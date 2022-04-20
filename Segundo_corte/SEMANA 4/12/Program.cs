using System;
namespace p_12
{
    class program
    {
        int datos;

        string[] mes = new string[12];
        int[] dia = new int[31];
        string[] info = new string[10];

        public void agenda()
        {
            Console.WriteLine("bienvenido a su agenda");
            
            Console.WriteLine("cuantos datos desea agregar");
            datos = int.Parse(System.Console.ReadLine());

            for (int i = 0; i < datos; i++)
            {
                mes[i] = "enero"; mes[i] = "febrero"; mes[i] = "marzo"; mes[i] = "abril";
                mes[i] = "mayo"; mes[i] = "junio"; mes[i] = "julio"; mes[i] = "agosto";
                mes[i] = "septiembre"; mes[i] = "octubre"; mes[i] = "noviembre";
                mes[i] = "diciembre";

                Console.WriteLine("\n estamos en el año 2022");
                Console.WriteLine("Digite el mes que desea");
                mes[i] = Console.ReadLine();
                if (mes[i] == "enero" || mes[i] == "marzo" || mes[i] == "mayo" || mes[i] == "julio" 
                    || mes[i] == "agosto" || mes[i] == "octubre" || mes[i] == "diciembre")
                {
                    Console.WriteLine("este mes tiene 31 dias\n ");
                    Console.WriteLine("Digite el numero del dia");
                    dia[i] = int.Parse(Console.ReadLine());

                    if (dia[i] < 0 || dia[i] > 31)
                        Console.WriteLine("ha digitado mal el dia");
                    else
                        Console.WriteLine("\n Digite la informacion a guardar ");
                    info[i] = Console.ReadLine();
                }
                if (mes[i] == "abril" || mes[i] == "junio" || mes[i] == "septiembre" || mes[i] == "noviembre")
                {
                    Console.WriteLine("\n este mes tiene 30 dias");
                    Console.WriteLine("Digite el numero del dia");
                    dia[i] = int.Parse(Console.ReadLine());

                    if (dia[i] < 0 || dia[i] > 30)
                        Console.WriteLine("ha digitado mal el dia");
                    else
                        Console.WriteLine("\n Digite la informacion a guardar ");
                    info[i] = Console.ReadLine();
                }
                if (mes[i] == "febrero")
                {
                    Console.WriteLine("\n este mes tiene 28 dias");
                    Console.WriteLine("Digite el numero del dia");
                    dia[i] = int.Parse(Console.ReadLine());

                    if (dia[i] < 0 || dia[i] > 28)
                        Console.WriteLine("ha digitado mal el dia");
                    else
                        Console.WriteLine("\n Digite la informacion a guardar ");
                    info[i] = Console.ReadLine();
                }
            }
            
        }
        private void mostrar()
        {
            for (int i = 0; i < datos; i++)
            {
                Console.WriteLine($"la fecha ingresada es \n 2022 / {mes[i]}/{dia[i]}");
                Console.WriteLine("");
                Console.WriteLine($"la informacion guardada es: \n {info[i]}\n ");
            }
        }
        static void Main(string[] args)
        {
            program ag = new program();
            ag.agenda();
            ag.mostrar();
        }
    }
}