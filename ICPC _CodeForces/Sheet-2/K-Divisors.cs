using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class K_Divisors
    {
        public static void Start() 
        {
            int n = int.Parse(Console.ReadLine());           
            Console.WriteLine(string.Join("\n",Enumerable.Range(1,n).Where(x=>n%x==0)));
        } 
    }
}
