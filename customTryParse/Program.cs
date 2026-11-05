using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
          




            Console.WriteLine(" Enter a number : ");

            if (TryParse(Console.ReadLine(), out int result))                    // the function will readLine what user input and passes it, and also pass result argument
            {

                Console.WriteLine("yey");
            }

            else
            {
                Console.WriteLine("oh no");
            }




        }
             

            static bool TryParse(string input, out int result)            // the input is already readline
            {
                result = 0;                                              // need to initialize the value to use it later
                
                try
                {
                    result = Convert.ToInt32(input);                     // the input is in string so we need to convet to int first, if success go to return, if not jump to catch block and skip return
                    return true;                                         
                }
                catch (Exception)                        // why we dont add format and overflow exception is because this is bool function, which only return true or false
                {
                    return false;                        // therefore e.Message is pointless
                }



            }
        }
    }







/*
          bool success = false;

          try
          {
              Console.Write("enter a number : ");
              int num = Convert.ToInt32(Console.ReadLine());
              success = true;
          }

          catch (FormatException e)
          {
              Console.WriteLine(e.Message);    
          }





          Console.WriteLine(success ? "Yeay " : "Oh No");
          */


