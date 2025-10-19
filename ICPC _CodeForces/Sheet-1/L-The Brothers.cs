using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class L_Solve
    {
        public static void Start() 
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            string inputs2 = Console.ReadLine();
            string[] parts2 = inputs2.Split(' ');
            if (parts.Length != 2 || parts2.Length != 2)
            {
                Console.WriteLine("Invalid input");
            }
            else if (parts[1] == parts2[1])
            {
                Console.WriteLine("ARE Brothers");

            }
            else if (parts[1] != parts2[1])
            {
                Console.WriteLine("NOT");
            }

        }
    }
}
