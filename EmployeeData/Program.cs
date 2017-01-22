using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            long pesonalIDNum = long.Parse(Console.ReadLine());
            int employeeNum = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}",firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", sex);
            Console.WriteLine("Personal ID: {0}", pesonalIDNum);
            Console.WriteLine("Unique Employee number: {0}", employeeNum);

        }
    }
}
