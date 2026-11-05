using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;    // better to not implement here and just include in the code to gain smaller size of project, if u only goin to use once

namespace StringIteration_looping_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string message = "C# is awesome";
            // string is actually just and char[] array


            Console.Write(message[0]);          // so you can just iterate through each array if u can see or know it
            Console.Write(message[1]);
            Console.WriteLine(message[2]);
            


            for (int i=0; i < message.Length; i++)    // but what if you can't and didnt know the length? then you can use method
            {

                Console.Write(message[i]);
                Thread.Sleep(100);                     // kinda like animation that runs in milisecond, so 250 milisecond
                
            }

            Console.WriteLine();
            Console.WriteLine(message.Contains("o"));




            bool containW = false;

            for (int i = 0; i < message.Length; i++)          
            {

                if (message[i].Equals('w')) {
                    containW = true;
                }


            }

            Console.WriteLine(containW);


            
          
        }
    }
}
