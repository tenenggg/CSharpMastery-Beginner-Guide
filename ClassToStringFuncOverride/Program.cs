using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classVariable_Function_sScope
{

    internal class Program
    {
        class Person
        {

            private string name;
            private int age;




            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = (!string.IsNullOrEmpty(value)) ? (value) : ("Invalid Input");
                }
            }
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = (value > 0 && value < 150) ? (value) : (-1);

                }
            }





            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }






            /* public string ReturnDetails()
            {
                return ($" My name is {name} and am {age} years old");
            }
            */





            // Every class inherits from `object`, which already has ToString() and Equals().
            // `override` replaces the inherited default with our own version.

            // ToString(): default only prints the class name.
            // Overriding it lets us choose the text which in this case $"My name is {Name} and am {Age} years old"
            // Console.WriteLine(person) calls this automatically.


            // Tip: type `public override` and Visual Studio shows a list of overridable methods. Press Tab to pick one.
            // This lets us call Console.WriteLine(person) directly and get our own text instead of the class name.
            public override string ToString()
            {
                return ($"My name is {Name} and am {Age} years old");
            }


            // Equals(): default compares references (same object in memory), not data.
            // Overriding it makes two Persons equal when their Name and Age match.
            public override bool Equals(object obj)
            {

                if (obj is Person)         // checks the type of object passed
                {

                    Person person = obj as Person;                              // like converting the obj as a person and assign to person
                    return Name.Equals(person.Name) && Age == person.Age;       
                }

                return false;        // not a person, can't be equal
            }
        }





        static void Main(string[] args)
        {

            Person person = new Person("Aba", 33);
            Person test = new Person("Aba", 33);

            Console.WriteLine(person);                          // WriteLine calls our overridden ToString() automatically



            if (person.Equals(test))                            // calls our overridden Equals(): compares Name and Age
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("Not the same");
            }
        }


        }
    }


        /*
          
         Console.WriteLine(person);             // WriteLine calls person.ToString() for you, calls our overridden ToString() automatically
         Console.WriteLine(person.ToString());  // same result, written explicitly
         Console.WriteLine($"{person}");        // string interpolation also calls ToString()
         person.Equals(test)                       calls our overridden Equals(): compares Name and Age


        */
