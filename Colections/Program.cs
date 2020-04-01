using System;
using System.Collections.Generic;
using System.Linq;

namespace Colections
{
    class Program
    {
        enum TestElem
        {
            Error = 1,
            Accept = 2,
            Gogo = 3,
            FirstClass = 4,
            YaEbal = 5

        }

        

        static bool Main(string[] args)
        {      int[] array = new int[3] { 1, -1, 1 };
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            if (array[i] > 0)
            {
                return true;
            }
            else return false;
            
            
            
            List<int> firstlist = new List<int>
            { 
                22,41,55,16,22
            };
            for (int b = 0; b < firstlist.Count; b++)
            {
                Console.WriteLine("Elements list = " + firstlist[b]);
            
            }
            Console.WriteLine(String.Join('\n',Enum.GetNames(typeof(TestElem))));
            Console.ReadKey(); 

        }
    }
}
