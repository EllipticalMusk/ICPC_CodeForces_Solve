using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class S_Solve
    {
        public static void Start()
        {
            float Input = float.Parse(Console.ReadLine());

            string Output = Input switch
            {
                >= 0f and <= 25f => "Interval [0,25]",
                >= 25F and <= 50F => "Interval (25,50]",
                >= 50F and <= 75F => "Interval (50,75]",
                >= 75F and <= 100F => "Interval (75,100]",
                _ => "Out of Intervals"

            };
            Console.WriteLine(Output);



        }
    }
}
