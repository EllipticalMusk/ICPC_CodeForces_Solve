using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class W_Solve
    {
        public static void Start()
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            

            int a = int.Parse(parts[0]),
                b = int.Parse(parts[2]);
            char op = parts[1][0];
            int Result = int.Parse(parts[4]);

            int result = op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                _ => 0,
            };
            if (Result == result)
                Console.WriteLine("Yes");
            else
                Console.WriteLine(result);
        }
    }
}
