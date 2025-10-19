using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class F_Solve
    {
        public static void Start() 
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            if (parts.Length != 2 || !long.TryParse(parts[0], out long x) || !long.TryParse(parts[1], out long z))
            {
                Console.WriteLine("Invalid input");

            }
            else
            {
                long last1 = x % 10;
                long last2 = z % 10;
                Console.WriteLine(last1 + last2);
            }
        }
    }
}
