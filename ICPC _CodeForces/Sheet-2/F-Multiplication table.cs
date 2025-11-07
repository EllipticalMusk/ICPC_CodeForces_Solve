using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class F_Multiplication_table
    {
        public static void Start() {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 12; i++) 
            {
                Console.WriteLine($"{n} * {i} = {i*n}");
            }
        }
    }
}
