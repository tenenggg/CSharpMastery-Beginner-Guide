using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_if_else_mini_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int answer = 1;          // int need to be initialize, because we use it immediately after this in conditions,  if not it will be error
            int actualAnswer = 0;    // also we need to put other value since it will be compared and doesnt matter what cause it will change after user input
           

            Console.Write("enter the first number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter the second number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());



            while( answer != actualAnswer)
            {
               

                actualAnswer = number1 * number2;


                Console.Write("enter the multiply of both 2 number : ");
                answer = Convert.ToInt32(Console.ReadLine());


                if (actualAnswer != answer)
                {
                    Console.WriteLine(" wrong please try again ");
                }
            }

            Console.WriteLine("correct ! great job");


            // in for loop it will be " for (int i = 0; answer != actualAnswer; i++) "
            // also in while loop we can't directly declare, assign  a variable like for loop
            // but still can do expressions like operators, comparisons and method calls.


        }
    }
}
