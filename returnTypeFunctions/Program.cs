using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returnTypeFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
              
            Console.Title = ReturnName();               // change the console terminal name
            PrintIntroduction();
            Console.ReadLine();                         // keep this is if u wanna see the console change names 





            int[] numbers = new int[3];

            for (int i=0; i < 3; i++)
            {
                numbers[i] = ReturnNumberFromConsole();

            }


            foreach ( var x in numbers)
            {
                Console.Write($" {x} ");
            }
        }





        static string ReturnName()            // not having void is what make it can return something
        {
            return "Imam";
        }

        static int ReturnAge()
        {
            return 23;
        }


        static void PrintIntroduction()
        {
            string name = ReturnName();
            int age = ReturnAge();
            string output = ($" My name is {name}  and my Age is {age}");
            Console.WriteLine(output);
        }


        static int ReturnNumberFromConsole()
        {
            Console.Write(" Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
            
        }


        //   you can also return array like this in a function      "  return new int[] { 1,2,3 };     instead of assigning the array to a variable and retrun it,
        //   and call the function and assign it to a new variable at main 



        /*
            the goal of functions is to make them do as little things as possible
            if there are 2 or more different things  doing a function
            the separate it

            because if we wanna reuse it, a certain calculation, and it involves 2 calculation,
            then we can't use it

            an example is the function PrintIntroduction (), u can separate it to 3 function actually, which is for name, age and output
            and i did that, which i call other functions to get the name and age
            if not, in the future, if you bundled up all of it into 1 functions, you can't get the name and age only

        */
    }
}
