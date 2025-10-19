using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class C_Solve
    {
        public static void Start() 
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            if (parts.Length != 2 || !double.TryParse(parts[0], out double x) || !double.TryParse(parts[1], out double m))
            {
                Console.WriteLine("Invalid input. Please enter two integers separated by a space.");
            }
            else
            {
                Console.WriteLine($"{x} + {m} = {x + m}");
                Console.WriteLine($"{x} * {m} = {x * m}");
                Console.WriteLine($"{x} - {m} = {x - m}");
            }

        }
    }
}
