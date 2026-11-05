using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayclearing
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = new int[] {

                34 , 2, 1, 4, 11, 21
            };



            
            
            // Array.Clear(numbers, 0, numbers.Length );               if u were to use arra method, this is the easiest one and below are the manual one

            // it has 3 arguments which is ( arrayname   , index to start clear   ,  clear until where) 
            //                                              can change indexes and length to your specific needs
            

            for (int i = 0; i < numbers.Length; i++)            
            { 
                numbers[i] = default;                                  // can be default or 0 since int default value is 0
            }

            foreach( int x in numbers)
            {
                Console.Write($" {x} ");
            }




        }
    }
}
