using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class T_Shape2
    {
        public static void Start() 
        {
            int n=int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++) 
            {

                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
                
            }
        }
    }
}
