using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFunctions
{
    internal class Program
    {

        // more cleaner way to pass parameters through function than string interpolation,concat, and out ref

        class Person
        {
            public string name;
            public int age;
            public int number;



            public Person(string name, int age, int number)
            {
                this.name = name;
                this.age = age;
                this.number = number;
            }

            public string ReturnDetails()                     // you can also create function in class, and now you dont have to pass arguments
            {                                                 // since its local, and to call it also different
                return ($" My name is {name} and are {age} years old");
            }

            public void something()
            {

            }
        }




        static void Main(string[] args)
        {

            Person person = new Person("Aba", 23,7);

            // Console.WriteLine(ReturnDetails(person));        // from function inside the scope of Program
            Console.WriteLine(person.ReturnDetails());          // from function inside the scope of class

        }



    /*  
        static string ReturnDetails(Person person)          // passing the whole class to use the class methods, if not can't
        {
            return ($" My name is {person.name} and are {person.age} years old");
        }

    */


    }
}
