using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class B_Even_Numbers
    {
        public static void Start()
        {
            int input = int.Parse(Console.ReadLine());
            if(input==1)
            { Console.WriteLine(-1);
                return;
            }    
            for (int i = 1; i <= input; i++) {
                
                if(i%2==0)
                Console.WriteLine(i);
            }


        }
    }
}
