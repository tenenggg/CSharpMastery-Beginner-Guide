using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace IfElse_and_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {




         

            Console.Write("enter your  name : ");                 
            string name = Console.ReadLine();

            Console.Write("enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());            

            Console.WriteLine("your  name is " +  name + " and you are " + age + " years old.");






            if ( age >= 1  && age <= 17 )
            {
                Console.WriteLine("you are under 18 !");  
            }

            else if ( age >= 18 && age <= 119)
            {
                Console.WriteLine("you are above 18 !");
            }

            else if ( age <= 0 || age >= 120)
            {
                Console.WriteLine("invalid age");
            }

            else
            {
                Console.WriteLine("invalid input");
            }

            // for string,  only the operator == and != is allowed, thats why we convert to int, and also string can even detect and empty space




             






        }
    }
}
