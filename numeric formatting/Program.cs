using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;      // to use different country time UTC and currency

namespace numeric_formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double value = 1000D / 12.34D;  // 81.0372771474878
            double value2 = 934.8429424D;
            double value3 = 3;
          

            Console.WriteLine(value);
            Console.WriteLine(string.Format( "{0:0.00}" , value));           // the first and second value is the format and the zeroes after . determine how many decimal point are there
            Console.WriteLine(string.Format( "{0:0.000}" , value2));
            Console.WriteLine(string.Format( "{0:0}" , value2));


            Console.WriteLine("\n");

            Console.WriteLine(value3);                                       // because we dont put the suffix D here, so it output as integer but the data is still in double
            Console.WriteLine(string.Format( "{0:0.00}" , value3));          // you can see it display as decimals


            Console.WriteLine("\n");


            Console.WriteLine(string.Format( "RM{0:0.00}" , value2));         // you can put anything inside " " before and after {}
            Console.WriteLine(string.Format( "RM" + "{0:0.00}" , value2));    // or you can just create another string to not mixed it with the formatting
            
            Console.Write("RM");
            Console.WriteLine(string.Format("{0:0.00}", value2));             // another simple way


            Console.WriteLine("\n");


            Console.WriteLine(value2.ToString("C"));                          // another way but using string function/method , C is currency
            Console.WriteLine(value.ToString("C"));                           // it will detect your region by your UTC date and give the currency format from there which is RM
            Console.WriteLine(value.ToString("C0"));                          // 0 dec place
            Console.WriteLine(value.ToString("C0"));                          // 1 dec place
            Console.WriteLine(value.ToString("C2"));                          // 2 dec place 

            Console.WriteLine("\n");

            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));    // changing the currency format to us (dollar)
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));    // changing the currency format to eu (pound)


            // better use the currency string method cause it follow a strict currency format




            // {0} is the standard and can be use for any data type whether int,double or etc
            // it will still shows the decimals but depends on your input and result, if its there, it will be shown
            // but if you wanna start controlling the specific decimalspoint then you need to start using {0:0}
            // and add zeroes to your need



            // also the {0} is called format string(or placeholder) which controls how the value is displayed, and the values after
            // are the arguments (format arguments) that fill in the format string (or placeholder)


        }
    }
}
