using System;
using System.Collections.Generic;          // sdictionary import
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Dictionary<int, string> names = new Dictionary<int, string>               // Dictionary format is almost the same as list, but have 2 data type
            {

                //KeyValuePair  , all the keys need to be unique, for value its okey, if the keys aren't unique, runtime error  
                { 1, "Aba"},
                { 2, "Test"},
                { 3, "Test"}
            };




            //  we can't use i in this case, cause i isnt index or position, its key, so its like searching for that key only
            for (int i = 0; i < names.Count; i++)             // again, same like list we dont have length, so use count instead
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);            // retrieving the keyvalue pair using Elementat and assign it to a variable 
                Console.WriteLine($" {pair.Key} - {pair.Value}"); 
            }

            Console.WriteLine();

            foreach (KeyValuePair<int, string> x in names)
            {   
                Console.WriteLine($" {x.Key} - {x.Value} ");

            }

            






            // try to find value from key by using trygetvalue, and changing it, and puttig ifelse to prevent exceptions
            // uncomment to see it runs
            /*
            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "Aba" },
                { "Science", "Test"}
            };



            if (teachers.TryGetValue("Math", out string teacher))           // trygetvalue is similar to tryparse  .trygetvalue(input, output)
            {
                Console.WriteLine(teacher);
                teachers["Math"] = "Joe";                                    // change the value for Math
            }

            else
            {
                Console.WriteLine(" output not found ");
            }


            if (teachers.ContainsKey("Math"))                               // removing the key value pair and adding ifs to prevent exceptions
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine(" key not found");
            }

            */
        }
    }
}
