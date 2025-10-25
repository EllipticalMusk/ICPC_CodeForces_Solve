using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Contest_1
{
    internal class E_Interval_Sweep
    {
        public static void Start() 
        {
            string input =Console.ReadLine();
            string[] parts = input.Split(' ');
            int n = int.Parse(parts[0]);
            int x = int.Parse(parts[1]);

            if (n==0&x==0||Math.Abs(n - x) >= 2) 
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
