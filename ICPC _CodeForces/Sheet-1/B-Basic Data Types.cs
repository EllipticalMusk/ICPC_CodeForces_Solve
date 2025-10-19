using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class B_Solve
    {
        public static void Start() 
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            if (parts.Length != 5 || !int.TryParse(parts[0], out int x) || !long.TryParse(parts[1], out long m) || !char.TryParse(parts[2], out char j) || !float.TryParse(parts[3], out float k) || !double.TryParse(parts[4], out double p))
            {
                Console.WriteLine("Invalid input. Please enter 4 integers separated by a space.");
            }
            else
            {
                Console.WriteLine($"{x}\n{m}\n{j}\n{k}\n{p}");

            }
        }
    }
}
