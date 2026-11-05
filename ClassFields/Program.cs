using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFunctions
{
    internal class Program
    {
        // get and set functions to restrict updating class fields  
        class Person
        {
            private string name;          // private only blocks code outside the class. 
            private int age;              // the constructor method like SetName are inside the class, so it they still assign private fields.     
                                          // so from outside(Main) you need to use constructor or methods to change the fields   




            public void SetName(string name)      // set class method
            {
                if (!string.IsNullOrEmpty(name))
                {
                    this.name = name;
                }
                else
                {
                    this.name = "Invalid Name";
                }
            }
            public void SetAge(int age)
            {
                this.age = (age > 0 && age < 150) ? (age) : -1;          // instead of if else, we use conditional or tertiary operator
            }





            public string getName()                 // get class method
            {
                return name;
            }
            public int getAge()
            {
                return age;
            }





            public Person(string name, int age)       // constructor    
            {
                this.name = name;
                this.age = age;
            }





            public string ReturnDetails()             // class method        
            {
                return ($" My name is {name} and are {age} years old");
            }

        }




        static void Main(string[] args)
        {

            Person person = new Person("Aba", 23);          // calls the  constructor to create object and assign the fields

            // line above is originally like this 
            // Person person;                               declares an empty variable
            // person = new Person("Aba", 23c)              creates an object and calls the constructor and assign values to the field

            Console.WriteLine(person.ReturnDetails());       // use class method to print



            // person.name("imam)                            // can't anymore since the class fields is private, will be error


            person.SetName("");                              // using set method to change class fields to invalid value
            person.SetAge(200);

            Console.WriteLine(person.ReturnDetails());                                                         // use class method to print
            Console.WriteLine($" My name is  {person.getName()} and am {person.getAge()} years old ");         // use get class method to print 
        }

    }



    // you can also use arrow method functions that can skipp a lot of lines like :

    //  public int getAge () => age;
    // and you dont have to put curly braces or return, to return the value


    // and remember the syntax for
    // creating class fields(variable)    :              public string variable
    // creating class method              :              public string/void/int  functionName (parameters)
    // creating class constructor         :              public Person (class variable1, class variable2)
    // creating class                     :              public Person

    // wondering why set needs parameters while get and some class doesnt?
    // if you need to change the value then it needs parameter
    // if you only need to read and return, then it doesnt
}
