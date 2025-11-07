using System;

namespace ICPC__CodeForces.Sheet_1
{
    internal class Z_Solve
    {
        public static void Start()
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            long[] value = new long[parts.Length];
            for (int i = 0; i < parts.Length; i++)
                value[i] = long.Parse(parts[i]);

            Console.WriteLine(Solve(value) ? "YES" : "NO");
        }

        public static bool Solve(params long[] A)
        {
            long a = A[0], b = A[1], c = A[2], d = A[3];

            
            if (a == 0 || c == 0)
                return a > c; 

            if (a == 1 && c == 1)
                return false;
            if (a == 1)
                return false;
            if (c == 1)
                return true;

            
            double left = b * Math.Log(a);
            double right = d * Math.Log(c);
            return left > right;
        }
    }
}
