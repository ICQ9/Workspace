using System;
using System.Linq;

namespace Kata1_1
{
    public static class Kata
    {
        public static bool XO(string input)
        {
                //bool XO;
                //text = "ooxxoxooxoxoxoxoxoxoxoxoxoxoxoxoxoxoxo";
                //text = text.ToLower();

                var countOne = 0;
                var countTwo = 0;

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == 'x' || input[i] == 'X')
                {
                    countOne++;
                }
                else if (input [i] == 'o' || input[i] == 'O')
                {
                    countTwo++;
                }

            }

            return (countOne == countTwo) ? true : false;
                
                }
            
            }
        }
    

            
                
                     
           
       
        
      