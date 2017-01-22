using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int calculatedSeconds = (hours * 3600) + (minutes * 60) + seconds;
            double exactHours = (double)calculatedSeconds / 3600;
            double metersPerSec = distanceMeters / (double)calculatedSeconds;
            double kmPerHour = ((double)distanceMeters / 1000) / exactHours;
            double milesPerHour = ((double)distanceMeters / 1609) / exactHours;
            Console.WriteLine("{0:0.000000}", metersPerSec);
            Console.WriteLine("{0:0.000000}", kmPerHour);
            Console.WriteLine("{0:0.000000}", milesPerHour);

        }
    }
}
