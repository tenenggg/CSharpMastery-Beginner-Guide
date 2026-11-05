using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outParameter_SIMPLER_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 10;
            changenumusingOut(out num);              // not (out int num) because we already declared


            Console.WriteLine(num);                  // the value now changes because we using void function that have out
        }

        static void changenumusingOut(out int num)
        {
            num = 20;
        }
    }
}
