using System;

namespace Kata_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;


            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = Convert.ToInt32(Console.ReadLine());

            string binnary = Convert.ToString(a + b, 2);


            Console.WriteLine("Binnary = " + binnary);
            Console.ReadLine();

            //return Convert.ToString(a + b, 2);
        }
    }
}
