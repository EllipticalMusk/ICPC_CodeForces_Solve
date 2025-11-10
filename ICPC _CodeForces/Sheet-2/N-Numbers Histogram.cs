using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class N_Numbers_Histogram
    {
        public static void Start() 
        {
            char x = char.Parse(Console.ReadLine());
            int n=int.Parse(Console.ReadLine());
            string s=Console.ReadLine();
            string[] output = s.Split(' ');
            for(int i = 0; i < n; i++) 
            {
                Histogram(int.Parse(output[i]),x);
                Console.WriteLine();
            }

        }
        static void Histogram(int x,char S) 
        {
            for(int i = 0; i < x; i++) 
            {
                Console.Write($"{S}");
            }

        }
    }
}
