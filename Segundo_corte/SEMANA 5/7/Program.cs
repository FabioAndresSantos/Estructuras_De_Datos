using System;
namespace program
{
    class p_7
    {
        int [] fam=new int[3];
        double [] servicios=new double[3];
        
        public void censo()
        {
            double v1,v2,v3;
            int a,l=0,g=0;
         for (a = 0; a < fam.Length; a++)
        {
            Console.WriteLine($"Digite el estrato de la familia");
              fam[a]=int.Parse(Console.ReadLine());
              
              Console.WriteLine("digite el valor del agua");
              servicios[a]=double.Parse(Console.ReadLine());
              
              Console.WriteLine("digite el valor de la luz");
              servicios[l]=int.Parse(Console.ReadLine());

              Console.WriteLine("digite el valor del gas");
              servicios[g]=int.Parse(Console.ReadLine());
               if (fam[a]==1){
              v1=((servicios[a] * 20)/100);
              v2=((servicios[l] * 20)/100);
              v3=((servicios[g] * 20)/100);
              Console.WriteLine($"el costo del agua es de :{v1} ");
              Console.WriteLine($"el costo de la luz es de :{v2} ");
              Console.WriteLine($"el costo del gas es de :{v3} ");}
              if (fam[a]==2){
              v1=((servicios[a]* 15)/100);
              v2=((servicios[l]* 15)/100);
              v3=((servicios[g]* 15)/100);
              Console.WriteLine($"el costo del agua es de :{v1} ");
              Console.WriteLine($"el costo de la luz es de :{v2} ");
              Console.WriteLine($"el costo del gas es de :{v3} ");}
              if (fam[a]>=3){
              v1=((servicios[a]* 9)/100);
              v2=((servicios[l]* 9)/100);
              v3=((servicios[g]* 9)/100);
              Console.WriteLine($"el costo del agua es de :{v1} ");
              Console.WriteLine($"el costo de la luz es de :{v2} ");
              Console.WriteLine($"el costo del gas es de :{v3} ");}
              l++;
              g++;
              Console.WriteLine();
        } 
        }
        static void Main(string[]args)
        {
          p_7 cen=new p_7();
          cen.censo();
        }
    }
}