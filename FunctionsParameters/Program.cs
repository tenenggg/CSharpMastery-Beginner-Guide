using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string name = ReadStr("Enter your name");           // passing a string parameter while processing input
            int num1 = ReadInt("Enter number 1");             
            int num2 = ReadInt("Enter number 2");

            Console.WriteLine($" Your name is {name} ");
            Console.WriteLine( Add(num1, num2) );             // pasing 2 integer parameter  to calculate

        }



        static string ReadStr(string message)                       // function to read string input
        {
            Console.Write($"{message} : ");
            return Console.ReadLine();
        }

        static int ReadInt(string message)                       // function to read number input and output message
        {
            Console.Write($"{message} : "); 
            return  Convert.ToInt32(Console.ReadLine());
        }

        static int Add(int a, int b)                               // function to add 2 numbers
        {
            return a+b;
        }






    }
}
