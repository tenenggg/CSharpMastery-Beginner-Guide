using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_fizzbuzz_game
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // mini quiz : 
            // print fizzbuzz for a number that divisible by 3 and 5, fizz for divisble by 3, and buzz for divisible by 5

            for (int i = 1; i <= 15; i++)
            {


                if ( i % 3 == 0 && i % 5 == 0)                        
                {

                    Console.WriteLine("FizzBuzz");
                }  

                else if ( i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }


                // if you want to make it more efficient, compute faster, use less memory and better readibility
                // assign the modulas to a variable at the start before if else and only calls the variable
                // so that the calculations doesnt happen everytime

            }

        }
    }
}
