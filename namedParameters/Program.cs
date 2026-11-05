using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace namedParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nameInput = "Imam";
            int ageInput = 23;
            string addressInput = "kuala lumpur";


            PrintDetails(address: addressInput,              // if these were to pass normally, it would be error, because of orders, but with this method, 
                         name: nameInput,                    // we can ignore the orders
                         age: ageInput);                     // this is called named parameters  

        }


        static void PrintDetails( string name, int age, string address)
        {

            Console.WriteLine($" you name is {name}, your age is {age}, and your adddress is {address}");
        }
    }
}
