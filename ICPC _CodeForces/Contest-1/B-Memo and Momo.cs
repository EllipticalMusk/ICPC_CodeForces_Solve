using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Contest_1
{
    internal class B_Memo_and_Momo
    {
        public static void Start() 
        {
            string input=Console.ReadLine();
            string[] parts = input.Split(' ');
            long a = long.Parse(parts[0]);
            long b = long.Parse(parts[1]);
            long k = long.Parse(parts[2]);
            if (a % k == 0 && b % k == 0) 
            {
                Console.WriteLine("Both");
            }
            else if (a % k == 0 && b % k != 0) 
            {
                Console.WriteLine("Memo");
            }
            else if(a % k != 0 && b % k == 0)
            {
                Console.WriteLine("Momo");
            }
            else {
                Console.WriteLine("No One");
            }

        }
    }
}
