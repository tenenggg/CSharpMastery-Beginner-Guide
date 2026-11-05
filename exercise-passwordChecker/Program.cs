using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_passwordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("enter your password");
            string password1 = Console.ReadLine();

            Console.WriteLine("enter your password again");
            string password2 = Console.ReadLine();


            if ((!string.IsNullOrEmpty(password1)) && (!string.IsNullOrEmpty(password2)))
            {

                if (password1.Equals(password2))
                    Console.WriteLine("Password Match");


                else
                    Console.WriteLine("Password do not match");
            }

            else
                Console.WriteLine("Please enter a password for both");
        }



        // instead of isnullorempty, you can use (!password1.Equals(string.Empty)) && (!password2.Equals(string.Empty))
        // because in this case we only need to check whether its empty or not, there could never be null since use will be inputting

        // you can also make more nested if else to go through more details checking because here it will only prompt please enter a password for both
        // when user is done inputting for both password, you can insert if else betwen each input to do more secure checking


        // some notes : password1.ToLower() and password1.ToUpper is method to check for lower or upper case sensitive character
    }
}
