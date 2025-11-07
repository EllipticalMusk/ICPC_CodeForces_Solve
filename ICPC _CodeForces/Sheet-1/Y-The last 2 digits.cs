using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class Y_Solve
    {
        public static void Start()
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            
            BigInteger a = BigInteger.Parse(parts[0]);
            BigInteger b = BigInteger.Parse(parts[1]);
            BigInteger c = BigInteger.Parse(parts[2]);
            BigInteger d = BigInteger.Parse(parts[3]);
            BigInteger e = a * b * c * d;
            string output =e.ToString();
            Console.WriteLine($"{output[output.Length-2]}{output[output.Length-1]}");

        }
    }
}
