using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class G_Solve
    {
        public static void Start() 
        {
            long n = long.Parse(Console.ReadLine());
            long sum = (n * (n + 1)) / 2;
            Console.WriteLine(sum);

        }
    }
}
