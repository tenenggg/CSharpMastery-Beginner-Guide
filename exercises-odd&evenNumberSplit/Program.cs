using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_odd_evenNumberSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // its impractical to type all the numbers into an array, so we do a list, which is dynamic
            // array are fixed size and its its size can't be change once u created it.
            // as list are dynamic, we dont need to know the final size ahead of time, and can change however whenever we want

            List<int> odd = new List<int>();
            List<int> even = new List<int>();



            for (int i = 0; i <= 20; i++)         // we can change the 20 to others, and the lists will adapt to it
            {
                if(i %2 == 0)                       // if the remainder is 0 then its an odd, if the remainder is 1 then its an odd
                {
                    even.Add(i); 
                }

                else
                {
                    odd.Add(i);
                }
            }

            // usually for if else we can just use conditional operator (condition)?(true):(false)
            // but in this case we need to assign it to a variable, so we cant

             foreach(var x in odd)
            {
                Console.Write($" {x} ");
            }


            Console.WriteLine();


            foreach (var x in even)
            {
                Console.Write($" {x} ");
            }

        }
    }
}
