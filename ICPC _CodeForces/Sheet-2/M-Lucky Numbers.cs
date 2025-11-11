using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class M_Lucky_Numbers
    {
        public static void Start() 
        {
            string input = Console.ReadLine();
            string[] input2 = input.Split(' ');
            long A = long.Parse(input2[0]);
            long B = long.Parse(input2[1]);

            var Lucky=Enumerable.Range((int)A,(int)(B-A+1)).Where(x=> IsLucky(x)).ToArray();
            if (Lucky.Length == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(string.Join(" ", Lucky));
            }



        }
        static bool IsLucky(long  X) 
        {
            string n = X.ToString();
            foreach (char c in n)
                if (c != '4' && c != '7')
                    return false;
            return true;

        }
    }
}
  