using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

            //MAIN:  NUMBER CONVERSION PROGRAM
            Console.WriteLine(numberConversion(500,15));
            string myStr = "hello";
            Console.WriteLine(myStr + "World");
            //CODE GOES HERE
            Console.WriteLine("Enter your denary number");
            int denary = Convert.ToInt32(Console.ReadLine());
            int remainder = 1;
            string binary = " ";
            while (remainder != 0) ;
            remainder = denary % 2;

        }

        //static void means the function will not return a value so it does not need a data type
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            //    CODE GOES HERE
            int calc = number + numberbase;
            string result = calc.ToString();
            return result; //REMOVE THE RED LINE

           
        }
       
    }
}
