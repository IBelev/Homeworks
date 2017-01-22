using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesInNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            ulong days = (ulong)(years * 365.2422m);
            int hours = (int)days * 24;
            ulong minutes = (ulong)hours * 60;
            ulong seconds = (ulong)minutes * 60;
            BigInteger miliseconds = seconds * 1000;
            BigInteger microseconds = miliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
