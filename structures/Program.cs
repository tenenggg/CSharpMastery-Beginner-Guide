using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structures
{
    internal class Program
    {

        struct Person                          // like a new variable profile
        {
            public string name;
            public int age;
            public int birthMonth;
            public int number;

            public Person(string name, int age, int birthMonth, int number)    // making a constructor for the struct to call it easier                 
            {
                                                                               // rather than assigning to Person person and person.name individually everything
                                                                                        
                this.name = name;                   
                this.age = age;
                this.birthMonth = birthMonth;
                this.number = number;
            }

        }



        static void Main(string[] args)
        {

            Person person; 
            person = ReturnPerson();    

            Console.WriteLine($" {person.name} - {person.age} - {person.birthMonth} - {person.number}");

        }




        static Person ReturnPerson()
        {
            Console.Write(" Enter your name: ");
            string name = Console.ReadLine();

            Console.Write(" Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter your birth month : ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter your favourite number : ");
            int number = Convert.ToInt32(Console.ReadLine());


            return new Person(name, age, birthMonth, number);               // give access to the struct constructor, to pass the value
                                                                            // rather than assigning to Person person and person.name individually
        }
    }
}

// struct is easier way to code rather than using ref or out parameter