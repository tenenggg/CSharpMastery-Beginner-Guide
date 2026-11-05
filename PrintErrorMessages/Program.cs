using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintErrorMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter a number : ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number);
            }

            catch (FormatException)                     
            {
                Console.WriteLine(" Please only enter a numbers !");
            }
            catch (OverflowException)                    
            {
                Console.WriteLine(" Please only enter a number less than 2 billion !");
            }
            catch (Exception e)                                     // e holds the exception object that was thrown at runtime. Exception catches any type of error
            {
                Console.WriteLine($" Error : {e.Message}");         // Message is a property of e, it gives the description of what went wrong
            }


            Console.WriteLine("goodbye");


        }
    }
}
