using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // tryparse is a function/method to convert string to int like Convert.ToInt32 
            // but the difference is it attempt the conversion and reports success or failure
            // instead of throwing exception and crashing like other method Convert.Toint32

            // so the out of tryparse will return the result of conversion if its true, if its false then it will return default value
            // thats why we make it to ifs statement because you wouldn know whether the value is true or false 

            //  so tryparse is like a bool that return true or false, if you dont believe me , try printing the statement itself
            //  or assign the statement tryparse to a variable and print it


            bool success = true;

            while (success)               // runs until success = false
            {
                Console.Write("Enter a number not a string : ");
                string num = Console.ReadLine();

                if (int.TryParse(num, out int resultNum)){               // the format of tryparse (input, out int result)

                    success = false;                                        // to stop the loop
                    Console.WriteLine(resultNum);
                    Console.WriteLine("correct format !");
                }

                else
                {
                    Console.WriteLine(resultNum);                                // 0 because 0 is a default int value
                    Console.WriteLine("incorrect format and fail to convert");
                }
            }

        }
    }
}
