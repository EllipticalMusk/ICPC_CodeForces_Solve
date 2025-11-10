using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class P_Shape1
    {
        public static void Start()
        {
            int n = int.Parse(Console.ReadLine());
            for (int k = n; k > 0; k--)
            {
                for (int i = k-1; i >=0 ; i--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
