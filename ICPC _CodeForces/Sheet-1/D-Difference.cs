using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class D_Solve
    {
        public static void Start()
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            if (parts.Length != 4 || !double.TryParse(parts[0], out double x) || !double.TryParse(parts[1], out double m) || !double.TryParse(parts[2], out double j) || !double.TryParse(parts[3], out double k))
            {
                Console.WriteLine("Invalid input. Please enter 4 integers separated by a space.");
            }
            else
            {
                Console.WriteLine($"Difference = {(x * m) - (j * k)}");

            }
        }
    }
}
