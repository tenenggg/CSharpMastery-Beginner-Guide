using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerbatingStringLiteral
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // \t    \n    \" \"    \\    ""  ""     ' '
            // new tab, new line(escape characters) , speech mark, quotation mark


            // there's 2 ways of displaying string, one is " ", and another is @" "
            // there's difference in format and rules when using them



            string speech = "He said \"something\" ";                                             //  \"\"  when inserting " " speech mark
            string path = "C:\\Users\\CoffeeNCode\\Desktop\\C# Course\nNew line test";            //   \\ when inserting \
            Console.WriteLine(path);
            Console.WriteLine(speech);



            path = @"C:\Users\CoffeeNCode\Desktop\C# Course" + "\nNew line test";                 // for @" "  you can't put escape characters like we put on " ", so need to use concatenation
            Console.WriteLine(path);

            string name = @"Hello ""someone""";                                                   // for @" ' you can make speech mark by use double speech mark
            Console.WriteLine(name);

            name = "Hello 'someone'";                                                             // for " " you can use quotation marks no problem
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
