using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversearray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] {

                 21, 4, 12 , 2, 90
            };

            
            Array.Reverse(numbers);                                     


            foreach (int x in numbers)
            {
                Console.Write($" {x} ");

            }
            


            // what if you want to do manually? without method reverse

            /*

                    int[] numbers2 = new int[numbers.Length];                    // numbers2 still have 0 array but have the space of 4 [ , , , , ]
                    int y = 0; 



                    for (int i = numbers.Length-1; i >= 0; i--)                  // right now the sequence is from 4-0
                    {
                        numbers2[y] = numbers[i];                                // numbers 2 start from 0(y) - 4, and numbers from 4-0
                        y++; 
                    }


                    foreach (int a in numbers2)                                  // now that numbers2 already have value, we can output it
                    { 
                        Console.WriteLine($" {a} ");
                    }


            */















        }
    }
}
