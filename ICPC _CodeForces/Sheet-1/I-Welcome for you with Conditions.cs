using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class I_Solve
    {
        public static void Start()
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            if (parts.Length != 2 || !double.TryParse(parts[0], out double x) || !double.TryParse(parts[1], out double y))
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                if (x >= y)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");

                }
            }
        }
    }
}
