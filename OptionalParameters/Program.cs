using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int result = Add(5);
            Console.WriteLine(result);

            PrintName("Imam");

        }

        static void PrintName(string name = "Joe")    // optional parameter that will insert Joe if there's no parameter passed, but if there is then it will override Jpe
        {
            Console.WriteLine($" My name is {name} ");
        }


        static int Add(int a, int b = default)       // same, you can either use default or [optional] int b , but for [optional] it will need for you to use import
        {                                            // or just ==  to the dfault value of that data type if you knew
                                                     // just use default easier
            return a + b;
        }
    }
}
