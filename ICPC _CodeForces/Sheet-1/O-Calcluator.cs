using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class O_Solve
    {
        public static void Start()
        {
            string input = Console.ReadLine();
            int opIndex = -1;
            char op = ' ';
            
            foreach(char c in new char[] { '+', '-', '*', '/' })
            {
                opIndex = input.IndexOf(c);
                if (opIndex !=-1) 
                {
                    op = c;
                    break;
                }
            }
            if (opIndex == -1) return;

            long a = long.Parse(input.Substring(0, opIndex));
            long b=long.Parse(input.Substring(opIndex+1));

            switch (op) 
            {
                case '+':
                    Console.WriteLine(a+b);
                    break;
                case '-':
                    Console.WriteLine(a-b);
                    break;
                case '*':
                    Console.WriteLine(a*b);
                    break;
                case '/':
                    if (b == 0) Console.WriteLine("Can not Diviide On zero");
                    else Console.WriteLine(a/b);
                    break;

                default:
                    break;
            }







        }
    }
}
