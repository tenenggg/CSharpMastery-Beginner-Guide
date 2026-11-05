using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> shoppingList = new List<string>
            {
                "Coffee", "Milk"
            };


            Console.WriteLine(shoppingList.IndexOf("Milk"));                      // shows the position of Milk from the list
            Console.WriteLine("\n");



            Console.WriteLine(FindInList("Milk", shoppingList, out int x));       // just like tryparse method, user input, data input and also get output
            Console.WriteLine(x);                                                 // call the value of x that was set by out parameter
            Console.WriteLine("\n");




            // ---------- Examples with other return types ----------

            // 1. string return, but
            string item = FindString("milk", shoppingList, out int b);
            Console.WriteLine(item + " at " + b);                                 // Milk at 1
            Console.WriteLine("\n");



            // 2. void return (everything comes back through out)
            FindVoid("milk", shoppingList, out int c, out bool ok);
            Console.WriteLine(ok + ", " + c);                                     // True, 1

        }







        // bool = returns true/false + out gives position
        static bool FindInList(string s, List<string> list, out int i)            // the arguments are passed into the parameters s and list. And i is the out parameter, which gets assigned to x in Main.
        {

            i = -1;                                                                // to indicate its not found

            for (int j = 0; j < list.Count; j++)
            {

                if (list[j].ToLower().Equals(s.ToLower()))                         // compare s and list, while changing both to lowercase for easier comparison
                {
                    i = j;                                                         // if same, then assign the position of the value to i
                }


            }

            return (i > -1);                                                       // if i more than -1 it will return true, if less then return false
        }


        // string = returns the item (null if not found) + out gives position
        static string FindString(string s, List<string> list, out int i)
        {
            i = -1;                                                                // not found by default

            for (int j = 0; j < list.Count; j++)
            {
                if (list[j].Equals(s, StringComparison.OrdinalIgnoreCase))         // case-insensitive compare
                {
                    i = j;                                                         // assign the position to i
                    return list[j];                                                // return the original item (keeps original casing)
                }
            }

            return null;                                                           // not found, so return null
        }


        // void = returns nothing, true/false and position both come through out
        static void FindVoid(string s, List<string> list, out int i, out bool found)
        {
            i = -1;                                                                // not found by default
            found = false;                                                         // out parameters must be assigned before the method ends

            for (int j = 0; j < list.Count; j++)
            {
                if (list[j].Equals(s, StringComparison.OrdinalIgnoreCase))
                {
                    i = j;                                                         // assign the position to i
                    found = true;                                                  // mark as found
                    break;                                                         // stop at first match
                }
            }
        }

    }


    // NOTE: Choose the return type based on the main answer you want: bool for yes/no (success check), int for a number/position, string for the actual item.
    // Use out when you need an extra value back besides the return, like bool + position (TryParse pattern).
}