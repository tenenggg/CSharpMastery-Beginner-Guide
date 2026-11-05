using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryNcatch
{
    internal class Program          
    {
        static void Main(string[] args)
        {


            bool looping = true;


            while (looping)
            {
                try
                {
                    Console.Write("Enter a number : ");
                    int number = Convert.ToInt32(Console.ReadLine());          // if sucess, proceed line below, and if fails, skip it and jumps to catch block depends on type of exceptions
                    Console.WriteLine(number);
                    looping = false;    
                }
                catch (FormatException)                      // if the input isnt integer
                {
                    Console.WriteLine(" Please only enter a numbers !");
                }
                catch (OverflowException)                    // the input is bigger than 2 billion, as int only allows the biggest number to be 2 billion
                {
                    Console.WriteLine(" Please only enter a number less than 2 billion !");
                }
                catch (Exception)                                                                           // this condition must only be last and not before those 2 exceptions, if not it will be error
                {
                    Console.WriteLine(" Something has went wrong! ");
                }

            }

            Console.WriteLine(" Goodbye! ");





        }
    }
}
