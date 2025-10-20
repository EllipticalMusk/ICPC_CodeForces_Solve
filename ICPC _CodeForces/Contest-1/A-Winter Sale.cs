using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Contest_1
{
    internal class A_Winter_Sale
    {
        public static void  Start() 
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            float a = int.Parse(parts[0]);
            float b=int.Parse(parts[1]);
            float Ans = b / (1 - (a / 100));
            Console.WriteLine(Ans.ToString("F2")); // Output: 1.24

        }
    }
}
