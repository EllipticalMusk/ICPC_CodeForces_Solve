using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class O_Pyramid
    {
        public static void Start() 
        {
            int n=int.Parse(Console.ReadLine());
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i <= k; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
