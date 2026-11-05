using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringisNullorEmptyFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" enter a text");
            string input = Console.ReadLine();    // try changing the assigment to Null to try and canceled out line below to try isNullorEmpty method

            



            //Console.WriteLine($" your name is : {input}");

            /*if (input != "")                                                           // empty string means it still holds value but a value of empty string
                Console.WriteLine(" your input is not an empty string");
            if (!input.Equals(""))                                                       // same, if not will print outputm but not checks whether its null or not
                Console.WriteLine(" your input is not an empty string ");
            */


            

            if (!string.IsNullOrEmpty(input) )                                            // will check both whether is empty or null, if not then output
            {
                Console.WriteLine(" your input is not an empty string or Null ");         // null is they have no value, the variable is blank

                if (input.Equals("Imam"))
                {
                    Console.WriteLine("Correct");
                }

                
            } 

            // so an empty string is still have a value of empty, while null is nothing
            // so isnullorempty function is good to improves stability of your program to ensure exceptions dont happen
         
        }
    }
}
