using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class Q_Digits
    {
        public static void Start() 
        {
            int n=int.Parse(Console.ReadLine());
            string []Input=new string[n];
            for(int i = 0; i < n; i++) 
            {
                Input[i] = Console.ReadLine();
                
            }
            for(int i = 0; i < Input.Length; i++) 
            {
                Console.WriteLine(string.Join(" ", Input[i].Reverse().Select(c=>c)));
            }

        }
    }
}
