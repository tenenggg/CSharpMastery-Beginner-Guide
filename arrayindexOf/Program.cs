using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayindexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = new int[]
            {
                2,12,23,35,50,1
            };



            Console.WriteLine(" Enter the number you want to search");
            int searchNum = Convert.ToInt32(Console.ReadLine());


            /*    array method ways

            int position = Array.IndexOf(numbers, searchNum);                                      // Array.IndexOf( array name , value of array searched, start index, end index )                                         

            if (position > 0 &&  position < numbers.Length)                                        // the position could be 0,1,2,3,4,5, if not error 
            {
                Console.WriteLine($" the position for number {searchNum} is {position+1} ");
            }

            else
                Console.WriteLine($" invalid number ");
            */



            bool foundNum = false;                                                                      
            int position = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (searchNum == numbers[i])
                {
                    foundNum = true;
                    position = i + 1;
                }

                    
            }
            
            if (foundNum == true) 
                Console.WriteLine($" The position for the number {searchNum} is {position} ");

            else
                Console.WriteLine(" invalid Number ");




            // when using method search or manual, its best to keep to the least amount to search, as it is will effect your perfomance
        
        
        
        }
    }
}
