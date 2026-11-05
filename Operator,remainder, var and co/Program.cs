using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_remainder__var_and_co
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Operators

            int age = 23;
            age++;
            age= age +1;
            age += 1;
            Console.WriteLine(age);
            
            age--;
            age = age - 1;
            age -= 1;
            Console.WriteLine(age);

            // all of the above are equivalent to each other, and they all increment or decrement the value of the variable by 1.
            // the same as * and /, we can use *= and /= to multiply or divide the value of the variable by a certain number.
            // but for int when u get a decimal value, it will round down to the nearest whole number, so 5/2 = 2, not 2.5, but for double and decimal it will give you the exact value.



            string name = "John";
            name += " Doe"; 
            name = name + " Smith";

            Console.WriteLine(name);

            // it will concatenate the strings together, and the result will be "John Doe Smith".
            // but it will be error if we try to use operator -, / and * with strings, because they are not defined for strings, and it will give us an error.

            // meanwhile for char it will give us the ascii value of the char, and we can use the operators with it, but it will not give us the expected result,
            // because it will treat the char as an int, and it will give us the ascii value of the char, so if we try to add 1 to a char, it will give us the next char in the ascii table,
            // and if we try to subtract 1 from a char, it will give us the previous char in the ascii table.


            int i = 0;
            Console.WriteLine(i++);
            Console.WriteLine(i);

            // the first line will print 0, because i++ is a post-increment operator, which means that it will return the value of i before it is incremented, and then it will increment the value of i by 1.
            // the second line will print 1, because the value of i is now 1.
            // if we use ++i instead of i++, it will be a pre-increment operator, which means that it will increment the value of i by 1, and then it will return the value of i after it is incremented.

            int j = 0;
            Console.WriteLine(++j);
            Console.WriteLine("\n");





            // == is for comparison expression while = is only for assignment




            // Remainder operator %



            int firstNum = 10;
            int secondNum = 3;

            Console.WriteLine(firstNum / secondNum);
            Console.WriteLine(firstNum % secondNum);

            // so to determine if a number is even or odd, we can divide it by 2 and if the remainder is 0, then it is even, otherwise it is odd.

            int evenorodd = 7;
            int evenorodd2 = 2;

            Console.WriteLine(evenorodd % evenorodd2);    // so 7 is odd because the remainder is 1














            // var keyword

            // for var keyword, it is used to declare a variable without specifying its data type, and the compiler will infer the data type based on the value assigned to the variable.
            // so the difference between var and dynamic is that var is statically typed, which means that the data type of the variable is determined at compile time,
            // while dynamic is dynamically typed, which means that the data type of the variable is determined at runtime.
            // therefore only use var when you are sure that the data type of the variable will not change, and use dynamic when you are not sure about the data type of the variable, and it may change at runtime.
            // by dynamic, you can assign any data type to the variable, and it will not give you an error, but it may cause an error at runtime if you try to use a method or property that does not exist for the data type of the variable.

            // so in conclusion if wanted a better performance, use var, but if you want readability and flexibility use dynamic
            // examples of when to use a var is like when you assigning a name, which obviously will be a string, or when you are assigning a number, which obviously will be an int or double, and so on.
            // but using too much var will makes it harder to read the code






            // const keyword
            // basically what the name implies, const is a constant value that cannot be changed after it is assigned, and it must be assigned a value at the time of declaration,

            const double pi = 3.14;
            // pi = 3.14159; // this will give an error because we cannot change the value of   a const variable after it is assigned.

            Console.WriteLine(pi);

            // but we can use it as many time as we want, and it will always have the same value

            double result = 2 * pi;
            Console.WriteLine(result);

        }
    }
}
