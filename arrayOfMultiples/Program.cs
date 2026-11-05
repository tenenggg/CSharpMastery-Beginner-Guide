using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayOfMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int num = 7;
            int length = 5;

            int[] result = new int[length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = num * (i+1); 
            }



            for (int i = 0; i < result.Length; i++)
            { 
                
                Console.Write($" {result[i]} ");
            }


            // or u can just create another variable like counter = 0, for more easy understanding
            // and you can ask user to input that after that
        }
    }
}
