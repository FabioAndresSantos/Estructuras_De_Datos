using System;

namespace Ejercicio5sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var prevDate = new DateTime(2021, 7, 15);
            var today = DateTime.Now;


            var diffOfDates = today - prevDate;

            Console.WriteLine("Difference in Timespan: {0}", diffOfDates);
            Console.WriteLine("Difference in Days: {0}", diffOfDates.Days);
            Console.WriteLine("Difference in Hours: {0}", diffOfDates.Hours);
            Console.WriteLine("Difference in Miniutes: {0}", diffOfDates.Minutes);
        }
    }


}
