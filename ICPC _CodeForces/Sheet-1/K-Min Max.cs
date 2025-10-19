using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    public class K_Solve
    {
        public static void Start()
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            PrintMaxandMin(input);
            

        }
        static void PrintMaxandMin(params long[] Numbers ) 
        {
            long max = Numbers[0];
            long min = Numbers[0];
            for(int i = 0;i<Numbers.Length; i++) 
            {
                if (max < Numbers[i]) 
                {
                    max = Numbers[i];
                }
                if (min > Numbers[i]) 
                {
                    min = Numbers[i];
                }

            }
            Console.WriteLine($"{min} {max}");

        }
    }
}
