using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class J_Primes_from_1_to_n
    {
        public static void Start()
        {

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", Enumerable.Range(2, n - 1).Where(IsPrime))); 
        }
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }


    }
}
