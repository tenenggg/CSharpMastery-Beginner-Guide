using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {

        /*
        struct Person
        {

            public string name;
            public int age;

            public Person (string name, int age)                                                 example 1 of struct, normal
            {
                this.name = name;
                this.age = age;
            }

        }




                struct Person
        {
            public string name;
            public int age;

            public Person(string name)
            {
                this.name = name;
                this.age = -1;        // must assign age too                             example 2 of struct, multiple constructor but 
            }
                                                                                         not single empty fields   
                                                                                         struct can't make empty constructor like class
            public Person(int age)                                                       and flexible like class
            {
                this.name = "";       // must assign name too
                this.age = age;
            }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        */

        class Person
        {

            public string name;
            public int age;


            public Person()                          // for class, you can make bunch of constructors and options, so that at main
            {                                        // you can either use the default constructor, or name, or age, or both
            }
            public Person(string name)               // you can also assign the default value of other variable like name = "" or age = -1
            {                                        // even if the constructor should have 1 argument
                this.name = name;                    // but if not assigned, string = null and int = 0
            }                                        // which are its default value   
            public Person(int age)
            { 
                this.age = age;
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

        }




        static void Main(string[] args)
        {
            Person person = new Person("aba", 23);      // to insert value to class  you can chose to put name,or age or both or not 
                                                        // if it is struct, you can still have multiple constructors, 
                                                        // every constructor must assign all the fields, look above for examples

            // person = new Person();                   // assigning again creates a new object, and person now points to it.

                                        // the old object has no reference left, so the garbage collector frees it from memory later                                                

            Console.WriteLine(person.name);
            Console.WriteLine(person.age);


            Console.Write("enter your new name : ");
            string newName = Console.ReadLine(); 
            
            Console.Write("enter your new age : ");
            int newAge = Convert.ToInt32(Console.ReadLine());

            person = new Person(newName, newAge);


            Console.WriteLine(person.name);
            Console.WriteLine(person.age);



        }


        // struct = value type (copied on assignment), good for small simple data like a point or coordinate
        // class = reference type (shared on assignment), supports inheritance, good for bigger or more complex objects
    }
}