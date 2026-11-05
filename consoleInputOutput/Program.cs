using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace consoleInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Enter your first name : ");
            string firstName = Console.ReadLine();

            Console.Write("enter your last name : ");                  // we can use Write instead of WriteLine to keep the cursor on the same line, so the user can enter the input on the same line as the prompt.
            string lastname = Console.ReadLine();

            Console.Write("enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());              // the reason convert is used here is because readline can't read the input as an int, it can only read it as a string, so we need to convert it to an int using Convert.ToInt32() method.

            // run console readline, then convert the input to int , then assign to age


            // the original way is
            // string ageInput = Console.Readline();
            // int age  = Convert.Toint32(ageInput);   

            // which is run console readline and assign to ageinput which is a string, then convert to int and assign to age
           


            Console.WriteLine("your  name is " + firstName + " " + lastname+ " and you are " + age + " years old.");



        }
    }
} 
