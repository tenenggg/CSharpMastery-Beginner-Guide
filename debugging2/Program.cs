using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace debugging2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "aba";
            int age;                      // you can see debug here is age = 0 ; cause 0 is the default value for integer
            age = 23;
        

            PrintDetails(name, age);       // you can also see the parameter value using debug
        }                                  // if you stepover(f10) after the line above, it will skip the function, and output all the data
                                           // so you need to stepin(f11) at the functin calls in main, above, to get into the function

        static void PrintDetails(string name, int age) 
        {                                                                   // and it will jump here
            Console.WriteLine($" {name} - {age}");                          // continue to stepover(f10) to see the output
            Console.WriteLine($" {name} - {age}");
            Console.WriteLine($" {name} - {age}");
            Console.WriteLine($" {name} - {age}");  
        }                                                                   // and you can stepout(f11) to get out of function, and go to function calls at main back
    }                                                                       // or you can just stepover(f10) again to go back

}

// you can also see at autos windows that it will update the value even if user input something to the program (not to the code, the terminal) 
// as it is a real time debug
// if u can't see the windows when debugging, just reset window layout at debug setting


// you can also see the watch windows, which u can insert variable to keep track
// to add the variables you either double click on the variable/ higlight it and rightclick and add watch
// you can also highlight it and drag and drop the variable
// you can also directly type on the watch list or even directly do conditions there, and even evaluate expressions
// and this variable will update the value based on where you step through the code you debug 
// you can also change the variable value directly on watch list without changing the code to view different output while debugging

// watch list is a good way to test the program into different values while debugging