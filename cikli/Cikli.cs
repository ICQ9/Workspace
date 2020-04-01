using System;
using System.Collections.Generic;
using System.Linq;

namespace cikli
{
    class Program
    {
        static void Main(string[] args)
        {
            //(for)
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            //(while)
            /*  var list = new List<string>();
              while (list.Count < 5)
              {
                  list.Add(Console.ReadLine());
              }
              var i = 0;
              while (i < list.Count)
              {
                  Console.WriteLine(list[i]);
                  i++;
              }
              Console.ReadLine();
              */

            //(do while)

            /* var list = new List<string>();
             while(list.Count < 0)
             {
                 list.Add(Console.ReadLine());
             }

             var i = 0;

             do
             {

             }
             while (i < list.Count);

             Console.ReadLine();

             */

            //(foreach)
            /* string list_numbers = String.Empty
             var list = new List<string>();
             for (var numbers = 0; numbers<= 15; numbers++)
             {

             }

             foreach (var item in list)
             {
                 Console.WriteLine(item);
             }
             //Console.ReadLine();               

     */     
            int number = 15;
            //Console.WriteLine("Enter amount of numbers: ");
            // try
            // {
            //      number = int.Parse(Console.ReadLine());
            // }
            // catch (FormatException ex)
            // {
            //      Console.WriteLine("Exeption");
            //  }
            List<int> list2 = new List<int>();
            List<int> list = new List<int>();
            for (int number2 = 0; number2 < number; number2++)
            {
                Console.WriteLine("Enter amount {0}", number2 + 1);
                try
                {
                    list.Add(int.Parse(Console.ReadLine()));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Exeption");
                }
            
            }

            list2.AddRange(list.ToArray());
            int sum1 = list2.ToArray().Sum();
            Console.WriteLine("Summ all numbers in list = " + sum1);

            
            var difference = list.ToArray();
            int result2 = difference[0];
            for (var i = 1; i < difference.Length; i++)
                result2 -= difference[i];
            Console.WriteLine("Difference all numbers in list = " + result2);


            list.ForEach(i => Console.Write("List :{0}\t",i));
                
                //Console.ReadLine();
        
        }

    }
}
