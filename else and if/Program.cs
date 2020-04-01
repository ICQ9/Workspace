using System;

namespace else_and_if
{
    class Program
    {
        static void Main(string[] args)
        {
            // && -  И (Операция умножения)
            // || - Или (Логическая операция +)
            // ! - Не

            Console.Write("Enter first number ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("Enrter second number ");
            int input2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number ");
            int input3 = int.Parse(Console.ReadLine());
            int a = 0;

            if (input1 > input2 && input1 > input3)
            {
                a = input1;
            }
            else if (input2 > input3 && input2 > input1)
            {
                a = input2;
            }
            else if (input3 > input2 && input3 > input1)
            {
                a = input3;
            }

            Console.WriteLine("Hight number = " + a);

            //var s = input == 10 ? "Yes" : "No";

            /* if (input <= 10)
             {
                 Console.WriteLine("Eblan");
             }
             else Console.WriteLine("Molodec");
             Console.ReadLine();
             */
            //int val = 5;
            switch (a % 2)
            {
                case 0:
                    Console.WriteLine("Even number");
                    break;
                case 1:
                    Console.WriteLine("Odd number");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            var s = a <100 ? "Yes" : "No";

            if (s == "Yes") Console.WriteLine("Number " + a + " less than one hundred");
            
            else Console.WriteLine("Number " + a + " is more than one hundred");
        }


    }
}