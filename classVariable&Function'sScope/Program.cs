using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classVariable_Function_sScope
{
    // compiler will always priotise the local variable than global variable
    // so lets say we make 2 similar variable with different value, 1 on global and 1 on local, the local value will output


    // Properties are the easier way to implement get/set.
    // You make a private field (name, age) and expose it through a public property (Name, Age).

    internal class Program
    {
        class Person {

            private string name;
            private int age;


            // Auto-implemented properties: the compiler creates a hidden private backing field for you, so it write there public but actually private
            // you don't declare name/age yourself. Use this when get/set need no extra logic like below, so you dont need to write longer get/set
            // (no validation, no transformation). Just a plain read and write. Example :

            // public string name {get; set;}
            // public    int age {get; set;}


            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = (!string.IsNullOrEmpty(value))   ?    (value) : ("Invalid Input") ;
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
                    age = ( value > 0 && value < 150)   ?   (value) : (-1) ;
                    
                }
            }

            // `value` = the implicit parameter of set. It holds the data being assigned to the property.
            // It's a keyword only inside set, so outside of it `value` is just a normal word.

            // u can also make arrow functions to save more lines : 

            // public string Name { get => name; set => name = value; }
            // public int Age { get => age; set => age = value; }
            // or you dont have to make all arrow, and some of it arrows, to gain maximum cleanition



            public Person (string name, int age)
            {
                Name = name;                 //  Assign to the properties (Name, Age) and not this. anymore for properties
                Age = age;
            }






            public string ReturnDetails()                    
            {                                            
                return ($" My name is {name} and am {age} years old");
            }

        }


        static void Main(string[] args)
        {

            Person person = new Person("aba", 33);
            Console.WriteLine(person.ReturnDetails());

            person.Name = "";                                     // Properties let you use it like a normal variable instead
            person.Age = 500;

            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine($" My name is {person.Name} and am {person.Age} years old");



        }


      
    }
}
