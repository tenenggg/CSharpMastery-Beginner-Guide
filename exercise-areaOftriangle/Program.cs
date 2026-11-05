using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_areaOftriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            int width = readInputandshowMessages("Please Enter width : ");
            int height = readInputandshowMessages("Please Enter height : ");

            double result = calculateArea(width, height);

            Console.WriteLine($" The area of triangle is {result} ");
        }


        static int calculateArea(int x, int y)
        {
            
            return (x * y) / 2; 

        }

        static int readInputandshowMessages (string messages)
        {
            Console.Write(messages); 
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
