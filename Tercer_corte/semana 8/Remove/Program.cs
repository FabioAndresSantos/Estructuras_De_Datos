using System;

namespace Remove
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mike Lorenzo Petersson";
            Console.WriteLine("The complete name is {0}",name);
            int whiteSpace = name.IndexOf(" ");
            name = name.Remove(whiteSpace + 1);
            Console.WriteLine("The removed form is: {0}", name);
        }
    }
}
