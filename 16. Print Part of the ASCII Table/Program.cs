using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            for (int i = startingNumber; i <= endNumber; i++)
            {
                char numToSymbol = Convert.ToChar(i);
                Console.Write(numToSymbol+ " ");
            }
            Console.WriteLine();
        }
    }
}
