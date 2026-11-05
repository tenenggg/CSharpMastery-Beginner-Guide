using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" What text u wanna loop ? : ");
            string text = Console.ReadLine();


            Console.WriteLine(" How many times you wanna loop ? : ");
            int numberofloop = Convert.ToInt32(Console.ReadLine());


            if (numberofloop <= 0)
            {
                Console.WriteLine("invalid number of loop, please enter a value above 0");

            }

            else
            {
                for (int i = 0; i < numberofloop; i++)
                {
                    Console.WriteLine(text);
                }

            }


            /* 
                what if for while loop?
             
                while ( i < numberofloop )           // the conditions
                {
                    Console.WriteLine(text)
                    i++
                }           



                for do while loop, is the same just that it will run do {} once then check the 
                while condition, if it  match the condition, then it will run do{} again until
                it doesnt matched
                
                so the difference is do while will always run once in do{} before checking the condition, while loop will check the condition first
                


                do {
               
                code that will run first before checking while condition and run again if it match the while condition
                
                } while (condition)

                





                 foreach ( int arrayvalue in num)                                            // foreach template is a bit different, ( int new_array_value   in    array)
                {                                                                           // it will loop through each array value wihtout having to be assign
                    Console.WriteLine("\n" + " " + arrayvalue);                             // so the downside is you can't control the specific
                }



             */

        }
    }
}
