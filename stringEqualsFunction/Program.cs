using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringEqualsFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string message1 = "Hello";
            string message2 = "Hello";


            if (message1.Equals(message2)){                 

                Console.WriteLine("same bro");
            }

            else
            {
                Console.WriteLine("not same bro");
            }





            Console.WriteLine("enter your name : ");
            string name = Console.ReadLine();


            if ( !name.Equals(string.Empty))               
            {

                Console.WriteLine($"Your name is {name}");
            }

            else
            {
                Console.WriteLine(" invalid name input ");
            }



            // we need to practise to use .Equals() rather than == or != 
            // because they may seem the same 
            // but the difference is .Equals() compares the literal value of the variables
            // while == compares the location that held the values inside memory address  and also the literal value itself (both)
            // which can be seen if you see the same 2 variable output value but different data type like string and object

            // which also means that == is more strict and more details to be checking both the value and memory
            // while .Equals() are only concerned of the literal values 

            // also if you are using .Equals for a single character we need to do .Equals(' ') while for string is .Equal(" ")

            



        }
    }
}
