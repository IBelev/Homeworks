using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int a = 2; a <= Math.Sqrt(i); a++)
                {
                    if (i%a==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} is prime -> {isPrime}");
            }            
        }
    }
}
