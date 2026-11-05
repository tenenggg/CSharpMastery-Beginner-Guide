using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace exercise_sumOfIntArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[]
            {
                1,2,3,4,5
            };

            int result = SumOfNumbers(numbers);





            if (result > -1)
            {
                Console.WriteLine($" the total is : {result}");
            }

            else
            {
                Console.WriteLine(" cannot add up an empty array ");
            }

        }


        static int SumOfNumbers( int[] numbers)
        {

            int total = 0;

            for (int i = 0; i < numbers.Length; i++)    //or foreach
            { 
                total += numbers[i];
            }

            return total;
        }
    }
}
