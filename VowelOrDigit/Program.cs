using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char charTyped = char.Parse(Console.ReadLine());           
            bool isVowel = "aeiouAEIOU".IndexOf(charTyped) >= 0;
            if (charTyped == '0' || charTyped == '1' || charTyped == '2' || charTyped == '3' || charTyped == '4' || charTyped == '5' || charTyped == '6' || charTyped == '7' || charTyped == '8' || charTyped == '9')
            {
                Console.WriteLine("digit");
            }
            else if (isVowel)
            {
                Console.WriteLine("vowel");

            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
