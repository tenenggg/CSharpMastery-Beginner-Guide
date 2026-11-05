using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_printStringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your message");
            string message1 = Console.ReadLine();


            for (int i = 0; i < message1.Length; i++)
            
            {
                Console.Write(message1[i]);
            }   


            Console.WriteLine("\n -------");

            for (int i = message1.Length-1 ; i >= 0; i--)             // for ( starting; end at ; increament/decreament )   so we swap the location to get reverse
            {
                Console.Write(message1[i]);                           // the i will follows the order based on for conditions
            }
            
            // because we use 0 as start so we need to -1 the length of message
            
        }
    }
}
