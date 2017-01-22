using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            object objectVariable = firstString + " " + secondString;
            string thirdString = (string)objectVariable;
            Console.WriteLine(thirdString);

        }
    }
}
