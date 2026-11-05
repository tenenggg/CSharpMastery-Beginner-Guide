using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ( condition ) ? true : false
            // this is conditional operator and can be used instead of if else for shorter code 

            int age = -10;

            string result = age >= 10 ? "Valid" : "Invalid";
            Console.WriteLine(result);






            // c# also have null coalescing operator which look the same as conditional operator
            // but actually checks for null and undefined instead of truth and false

            string name = "imam";
            string pass = name ?? "Guest";


            Console.WriteLine(pass);

            

        }
    }
}
