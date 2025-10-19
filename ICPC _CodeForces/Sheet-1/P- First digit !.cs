using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class P_Solve
    {
        public static void Start() 
        {
            int input = int.Parse(Console.ReadLine());
            int firstdigit = int.Parse(input.ToString()[0].ToString());
            Console.WriteLine(Even(firstdigit));

        }
        static string Even(int value)
        {
            if (value % 2 == 0) return "EVEN";
            else return "ODD";
    
        }
    }
}
