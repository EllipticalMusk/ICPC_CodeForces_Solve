using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class U_Solve
    {
       public static void Start() 
       {
            string input=Console.ReadLine();
            string[] Parts = input.Split('.');
            int.TryParse(Parts[1], out int num);
            if ( num> 0) 
            {
                Console.WriteLine($"float {Parts[0]} 0.{Parts[1]}");
            }
            else {
                Console.WriteLine($"int {Parts[0]}");
            }
       }
    }
}
