using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num);    

            // there's a few type of exceptions like  format (not in correct format)
            // overflow (value either too large or too small)
            // but all in all the program doesnt have code that enough to handle these exceptions
        }
    }
}
