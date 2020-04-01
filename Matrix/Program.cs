using System;
using System.Threading;
using System.Runtime.InteropServices;


namespace Matrix
{
    class Program
    {
        [DllImport("msvcrt")]
        static extern int _getch();
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            string word = "Wake Up, Neo...";
            
            foreach (char letter in word)
            {
                Console.Write(letter);
                Thread.Sleep(600);
            }
            Thread.Sleep(1000);
            Console.WriteLine();
            Thread.Sleep(200);
            Console.Clear();
            string word2 = "The Matrix has you...";
            foreach (char text in word2)
            {
                Console.Write(text);
                Thread.Sleep(600);
            }
            _getch();
            Console.WriteLine();
            Console.Clear();
            string word3 = "Folow the white rabbit.";
            foreach (char text2 in word3)
            {
                Console.Write(text2);
                Thread.Sleep(500);
            }
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Knock,knock,Neo.");
            Console.Clear();
            Console.ReadLine();
        }
        
 
    
    }

    class Program2    
    {
        static void TestSupp(string[] args)
        {
            Class1 class1 = new Class1();
            int b = class1.abs;
            Console.WriteLine(b);

        }

    }

}
