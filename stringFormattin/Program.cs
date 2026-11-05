using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFormattin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name1 = "Imamuddin";
            int age = 23;

            

            // first old way
            Console.WriteLine(" your name is : " + name1 + "\n your age is : " + age);


            // composite formatting
            Console.WriteLine(" your name is : {0} \n your age is {1}", name1, age);               // cleaner way 




            // String Interpolation , method of concatenation to looks better
            Console.WriteLine($" your name is : {name1} \n your age is : {age}");                         // more cleaner way



            // string concatenation other methods
            Console.WriteLine(string.Concat("your name is : ", name1, "\n your age is : ", age));        // string method (string.concat) 

            string[] names = new string[] { "Ali ", "Abu ", "Ajim ", "Arif " };                             // can also be used to join arrays

            Console.WriteLine(string.Concat(names));



            // in general i want to use string interpolation for the best readibility and cleaner way
            // but in some cases string concat is better for readibility
            // and if output are short, you can just use any





        }
    }
}
