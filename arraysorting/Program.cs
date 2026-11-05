using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysorting
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = new int[] { 4, 19, 2, 22, 9,1 };



            Array.Sort(numbers);                           // method to sort the orders of number of array  


            foreach ( int x in numbers )
            {
                Console.Write($" {x} ");
            }







        }
    }
}
