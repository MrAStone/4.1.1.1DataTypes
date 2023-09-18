using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._1._1DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // integer
            int myNumber;
            myNumber = 10;
            int myNumber2 = 20;
            int myNumber3 = myNumber + myNumber2;
            //real - Different options, for float and decimal a digit needs to be added.
            // For simplicity, use double
            float myFloat = 0.3F; // low precision 6-9 digits
            double myDouble = 1.23456; // higer precision 15-17 digits
            decimal myDecimal = 1.31646m; // highest precision 28-29 digits
            // Boolean
            bool myBoolean = false;
            bool myBoolean2 = true;
            // character
            char myChar;
            myChar = 'a';
            char myChar2 = 'A';
            //• string.
            string myString = "This is a string";
            string myString2;
            myString2 = "";
        }
    }
}
