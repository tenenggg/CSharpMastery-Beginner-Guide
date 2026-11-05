using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Welcome();
            CreateAndPrintArray();                    // in these 2 function is a void function which we can't return a value, only did to run some functionalities
                                                      // it runs the functions and delete the data in memory immediately after the function ends
        }




        static void Welcome()
        {
            Console.WriteLine(" welcome to my program !");
        }


        static void CreateAndPrintArray()
        {

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            foreach ( int x in numbers)
            {
                Console.WriteLine($" {x} ");
            }

        }
    }
}
