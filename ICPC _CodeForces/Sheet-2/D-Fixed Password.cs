using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class D_Fixed_Password
    {
        public static void Start()
        {
            const int Password = 1999;
            int result = 0;
            while (result != Password)
            {
                int.TryParse(Console.ReadLine(), out result);
                if (result != Password)
                    Console.WriteLine("Wrong");
            }
            Console.WriteLine("Correct");
        }
    }
}
