using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string toHex = Convert.ToString(n, 16);
            string toBinary = Convert.ToString(n, 2);          
            toHex = toHex.ToUpper();
            Console.WriteLine(toHex);
            Console.WriteLine(toBinary);

        }
    }
}
