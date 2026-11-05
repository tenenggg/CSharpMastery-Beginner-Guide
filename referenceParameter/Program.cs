using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outParameter_SIMPLER_
{
    internal class Program
    {


        // passing by reference is when you also pass the memory address location of that variable, rather than only the value
        // the method is the same as out but the main difference is for out u need to make use of the value u pass even if u dont wanna change it(you need to assign it in the function)
        // while ref didnt need to, you can assign in ref, but you dont have to if you dont wanna change the value

        // also by ref is quicker in term of program speed and efficiency cause you dont create another variable but u replace it
        static void Main(string[] args) 
        {

            int num = 10;
            string name = "Imam";
            Assign(ref num, ref name);                        // not (out int num) because we already declared



            Console.WriteLine(num);                  // the value now changes because we using void function that have out
            Console.WriteLine(name);        
        }

        static void Assign(ref int num, ref string name)
        {
            num = 20;
            name = "Imamuddin"; 
        }
    }
}
