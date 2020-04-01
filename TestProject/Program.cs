using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*не явное преобразование
            * int i=1;
            * string s= "str" + i;
            * 
            * явное преобразование
            * int iii= Convert.ToInt32(s);
            * int iiii = int.Parse("42");

              string s = "1234";
              int jojo = (int)s; //ошибка

              //явное приведение
              int ii = 5;
              int j = 2049;
              byte q = (byte)ii; //ошибка
              byte bb = (byte)j;

              //не явное приведение
              byte b = 42;
              int i = b;
              */

            bool b = true;
            string s = b.ToString();

            Console.WriteLine(b);
            Console.ReadLine();

            //sting s = "false";
            //bool b = Convert.ToBoolean(s);
            //Если он сможет спарсить 123 он выведет значение, если нет exeption
            if (int.TryParse("123", out int result))
            {
                Console.WriteLine(result);            
            }
        }
    }
}
