using System;
using System.Collections;

namespace Ejercicio3
{
    class Socio
    {
        protected string[] Nombre;
        protected int[] Antiguedad;
        
        public Socio()
        {
            Nombre=new string[3];
            Antiguedad=new int[3];
            for(int i=0;i<3;i++){
                Console.WriteLine("Digite el nombre del socio: ");
                Nombre[i]=Console.ReadLine();
                Console.WriteLine("Digite la antiguedad en años: ");
                Antiguedad[i]=int.Parse(Console.ReadLine());
            }
        }
       
    }
    class Club: Socio
    {
         
        public void MayorAntiguedad()
        {
            int Anti=Antiguedad[0];
            string Nom=Nombre[0];
            for(int i=0;i<3;i++){
                if(Antiguedad[i]>Anti){
                    Anti=Antiguedad[i];
                    Nom=Nombre[i];
                }
            }
            Console.WriteLine($"El socio: {Nom} tiene la mayor antiguedad de: {Anti}");
        }
        static void Main(string[] args)
        {
            Club op=new Club();
            op.MayorAntiguedad();
        }
    } 
}
