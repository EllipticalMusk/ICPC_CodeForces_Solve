using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class C_Even_Odd_Positive_and_Negative
    {
        public static void Start()
        {
            int input=int.Parse(Console.ReadLine());
            string input2=Console.ReadLine();
            string[] parts = input2.Split(' ');
            int even=0, odd=0, P=0,N=0;
            for (int i = 0; i < parts.Length; i++) 
            {
                int n=int.Parse((parts[i]));
                if(n%2==0)
                    even++;
                if(n%2!=0) 
                    odd++;
                if (n > 0)
                    P++;
                if (n < 0)
                    N++;

            }
            Console.WriteLine($"Even: {even}\nOdd: {odd}\nPositive: {P}\nNegative: {N}"); 


        }
    }
}
