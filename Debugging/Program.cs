using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 35;

            if (age > 18)
            {
                Console.WriteLine("18+");
            }

            else if(age > 30)                                // if you click the gap before the line number and press f5 or debug to run, it will start to debug at that line, it can be anywhere u want
            {                                                // and when u stepover(f10) it will move towards next line, and skips on based on conditions
                Console.WriteLine("30+");                    // in this case it will skips 30+ since its true at if statement, so it skips the else if
            }

        }                                                    // if you wanna stop the debug, just press continue or f5 to run the whole program
    }

    // also u can't put a debug line on a statement that only declaring a variable like int age;     ,       initializing can
    // and u can also create multiple debug point, and disable the one you dont want to starts with
}
