using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class L_GCD
    {
        public static void Start() 
        {
            string Input=Console.ReadLine();
            string[] parts = Input.Split(' ');
            int a=int.Parse(parts[0]);
            int b=int.Parse(parts[1]);

            while (b != 0) 
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine(a);
        }
    }
}
