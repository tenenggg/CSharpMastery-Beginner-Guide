using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" how much array you want ? :");
            int x = Convert.ToInt32(Console.ReadLine());    

            int[] num = new int[x];                                                     // num has x array

                




            for (int i = 0; i < num.Length; i++)
            {

                Console.WriteLine($"insert the number for the array {i+1}");             // i+1 doesnt effect the for loop because its not assignment like i++/i=i+1
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n");



             
            for (int i = 0; i < num.Length; i++)
            { 
                Console.Write(" " + num[i]);
            }



            foreach ( int arrayvalue in num)                                            // foreach template is a bit different, (int new_array_value in array)
            {                                                                           // it will loop through each array value wihtout having to be assign
                Console.WriteLine("\n" + " " + arrayvalue);                             // so the downside is you can't control the specific
            }


            // if we doesnt use for loop, it will be tedious to create manually like:
            // num[0] = Convert.ToInt32(Console.ReadLine());
            // num[1] = Convert.ToInt32(Console.ReadLine());














        }
    }
}
