using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> listNum   = new List<int>();                 // List<VariableType> VariableName = new List<VariableType>();     the format


            // you can also initialize list like array which {} after above to insert own value
            // listNum.       if you type this, the lists of method will appear, and you can check each one with its description



            for (int i = 0; i < 3; i++)
            {

                Console.Write("Enter a number : ");
                int num = Convert.ToInt32(Console.ReadLine());

                listNum.Add(num);                                         // Add is use to adds to the end of the list
            }





            for (int i = 0; i < listNum.Count; i++)                       // in list we dont have length, so we use count instead
            {
                Console.Write($" {listNum[i]} ");
            }


            Console.WriteLine("\n");
            listNum.RemoveAt(2);                                          // one of the methods, removing value at index 2





            foreach( int x in listNum)                                    // or we can just use foreach loop instead of above
            {
                Console.Write($" {x} ");
            }


            listNum.Add(3);                                               
            Console.WriteLine("\n");





            foreach (int x in listNum)
            {
                Console.Write($" {x} ");
            }







        }
    }
}
