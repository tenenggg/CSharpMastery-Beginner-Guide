using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFunctions
{
    internal class Program
    {

        class Person
        {
            public string name;
            public int age;



            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }




        static void Main(string[] args)
        {

            Person person = new Person("Aba", 23);

            Console.WriteLine(ReturnDetails(person.name, person.age));


        }



        static string ReturnDetails(string name, int age)
        {
            return ($" My name is {name} and am {age} years old");      // string function can only return a string, not an int. In this case
        }
    }
}
    // Here the int is converted to text inside the string interpolation, so the returned value is a string.
    // The original variable (age) is still an int, interpolation only makes a text copy of it.
                                                
    // this is one of the ways you can output 2 or more values while function can only return 1 values
    // in this case 1 string value that contains multiple converted value
    // other ways are like using out or ref parameter, and also returning whole person object, which is on the next files ClassFunctions2
    
    // this method string interpolation u used also the same as string concat(concatenation) just different format