using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_TimeTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number that you wanna multiply with from 1 to 10 : ");
            int timetableNumber = Convert.ToInt32(Console.ReadLine());                                              //since readline can only read string


            for (int i=1; i <=10; i++)
            {
                int result = timetableNumber * i;

                Console.WriteLine("{0} x {1} = {2}", i , timetableNumber,result );

            }


            // we can also use double to get decimals, but change the data type and method(convertdouble)
            // as for the placeholder u can use {0} as it is and it will still show the decimals depends on your input decimals point and result
            // or change to more specific format 
            // but need to be using {0:0} and add the zeroes to your needs like {0:0.000}



        }
    }
}
