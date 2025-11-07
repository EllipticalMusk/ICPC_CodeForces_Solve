using System;

namespace ICPC__CodeForces.Sheet_1
{
    internal class V_Solve
    {
        public static void Start()
        {
            string[] parts = Console.ReadLine().Split(' ');
            int A = int.Parse(parts[0]);
            char op = parts[1][0];
            int B = int.Parse(parts[2]);

            bool result = op switch
            {
                '>' => A > B,
                '<' => A < B,
                '=' => A == B,
                _ => false
            };

            Console.WriteLine(result ? "Right" : "Wrong");
        }
    }
}
