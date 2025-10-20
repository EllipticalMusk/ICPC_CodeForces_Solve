using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
namespace ICPC__CodeForces.Sheet_1
{
    internal class Z_Solve
    {
        public static void Start() 
        {
            string Input = Console.ReadLine();
            string[] Parts = Input.Split(' ');
            long[] Value=new long[Parts.Length];
            for (int i = 0; i < Parts.Length; i++) 
            {
                Value[i]=long.Parse(Parts[i]);
            }
            if (Solve(Value))
            {
                Console.WriteLine("YES");
            }
            else 
            {
                Console.WriteLine("NO");
            }


        }
        public static bool Solve(params long[]A) 
        {

            bool Result = A[0]*Math.Log(A[1]) > A[2]*Math.Log(A[3]);
            return Result;
        }
    }
}
