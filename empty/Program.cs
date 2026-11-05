using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace empty
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // string.Empty is the same as only declaring it as string name;  or  string name = " ";    
            // so the reason why we use this is because we want to have a more readibility or representative look to other reader
            // and we can also accidently  leave or add extra space on the assignment "   "
            // we also need an assignemnt to make expression to be used as conditions;


            
                Console.WriteLine("enter your name");
                string name = Console.ReadLine();


                if (name != string.Empty)                   
                {

                    Console.WriteLine($"your name is {name}");

                }

                else
                {
                    Console.WriteLine("Your Input is Empty");
                }

            
        }
    }
}
