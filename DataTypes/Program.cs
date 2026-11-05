using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("HELLO WORLD");
            Console.WriteLine("\n");



            // Numeric Data Types


            int age = 23;
            long bigNumber = 1234567890123456789L;        // The 'L' suffix indicates that this is a long literal, if not specified, the compiler will treat it as an int literal and may cause an error if the value exceeds the range of int.
            double dnumber = 3.14D;                       // doesnt need since c# treats it as double by default, but can be used for clarity
            float fnumber = 3.14F;                        // The 'F' suffix indicates that this is a float literal, if not specified, the compiler will treat it as a double literal and may cause an error if the value exceeds the range of float.
            decimal decinumber = 3.14M;                   // The 'M' suffix indicates that this is a decimal literal, if not specified, the compiler will treat it as a double literal and may cause an error if the value exceeds the range of decimal.


            // in general we use int for whole numbers, double for decimal numbers, and decimal for financial calculations where precision is important,
            // while float is used for less precise calculations where performance is more important than precision, and long is used for very large whole numbers.

            // extra notes : int can't read the 0 at the beginning of a number, so to store a number with leading zeros,
            // we can use string data type instead of int, and then convert it to int when needed.


            Console.WriteLine(age);
            Console.WriteLine(bigNumber);
            Console.WriteLine(dnumber);
            Console.WriteLine(fnumber);
            Console.WriteLine(decinumber);

            // but if you were to declare the decimals data type like double,float,decimal in an not decimal form, the output will no be shown in decimals
            // form unless you format it, like example a double x = 3D;  will be shown 3, not 3.000

            Console.WriteLine(int.MaxValue);             // here we are using the MaxValue property of the data type to get the maximum value that can be stored in an int, decimal, double, etc.
            Console.WriteLine(int.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);



            int x, y, z;                 // declaring variables

            x = 5;                        // assigning values to variables / initializing variables
            y = 10;
            z = x + y;
            int a = 5;                    // declaring and assigning values to variables in one line / initializing variables

            Console.WriteLine(z);
            Console.WriteLine(a);









            // Text based Data Types


            string name = "Imam";
            char name2 = 'I';                    // ' ' is used for char data type, while " " is used for string data type, if you use " " for char data type, it will cause an error, and if you use ' ' for string data type, it will cause an error as well.
            string name3 = " ";                  // empty string can be but not for char data type, it will cause an error, but you can use '\0' for char data type to represent an empty char.

            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);








            // converting string to int


            string text = "123";
            int convert = Convert.ToInt32(text);            // converting string to int using Convert.ToInt32() method
            Console.WriteLine(convert);


            string text2 = "1231231231232145";
            long convert2 = Convert.ToInt64(text2);            // converting string to long using Convert.ToInt64() method
            Console.WriteLine(convert2);

            string text3 = "123.45";
            double convert3 = Convert.ToDouble(text3);            // converting string to double using Convert.ToDouble() method
            Console.WriteLine(convert3);


            string text4 = "123.45";
            float convert4 = Convert.ToSingle(text4);            // converting string to float using Convert.ToSingle   () method
            Console.WriteLine(convert4);

            string text5 = "123.45";
            decimal convert5 = Convert.ToDecimal(text5);            // converting string to decimal using Convert.ToDecimal() method
            Console.WriteLine(convert5);

            //  dont need L, D, F, M suffixes when converting from string to numeric data types using Convert class methods,
            //  because the methods will automatically convert the string to the appropriate numeric data type based on the method used.





 


            // boolean Data Type


            bool isMale = true;
            bool isFemale = false;

            Console.WriteLine(isMale);
            Console.WriteLine(isFemale);




            // there's also var which is a keyword like const, object, dynamic, readonly 
            // but string, int, double and etc is also keywords its just that its specific to their own data type
            // because var can be anything as when u declare it, it will read the source of that data assign to var, and declare what it is
            // so you can use var  to be flexible , and use data type when u are sure of that variable data type
        }
    }
}
