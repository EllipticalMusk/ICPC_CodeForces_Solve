using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Contest_1
{
    internal class F_Adding_Bits
    {
        public static void Start() 
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            Console.WriteLine(a^b);

        }
    }
}
