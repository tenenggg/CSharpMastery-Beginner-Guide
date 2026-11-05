using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Test                      // this is an instance
    {
        public static void something()        // and if you wanna call a function that is not static, then u need to create an instance of the class, see the example at Main() function 
        {
            Console.WriteLine("something");
        }
    } 
    




    
    class Program              // this is the main instance cause Main() is here
    {
        static void Main()           // Main() is what matters the most, it needs this to run anything, and also are case sensitive
        {

            WelcomeMessage();         // calling from same instance
            Test.something();         // calling from other instance
            
            // Test test = new Test(); test.something() 


        }


        static void WelcomeMessage()       // static means we can access it anywhere and everywhere
        {
            Console.WriteLine("welcome imam");

        }
    }
}
