using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class S_Sum_of_Consecutive_Odd_Numbers
    {
        public static void Start()
        {
            int Count = int.Parse(Console.ReadLine());
            string[] Input = new string[Count];
            for (int i = 0; i < Input.Length; i++)
            {
                Input[i] = Console.ReadLine();
            }
            for (int i = 0; i < Input.Length; i++) 
            {
                string []s=Input[i].Split(' ');
                int x = int.Parse(s[0]);
                int z = int.Parse (s[1]);
                Console.WriteLine(SumOfOdd(x, z));
            }
            

        }
        static int SumOfOdd(int  Start,int End) 
        {
            int Min = Math.Min(Start, End);
            int Max = Math.Max(Start, End);
            int sum = 0;
            
            for(int i = Min+1; i < Max; i++) 
            {
                if (i % 2 != 0)
                    sum=sum+i;
            }
            
            return sum;
        }
    }
}
