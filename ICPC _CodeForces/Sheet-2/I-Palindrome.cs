using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class I_Palindrome
    {
        public static void Start()
        {
            string input = Console.ReadLine();
            string Revesed = "";
            for(int i = input.Length - 1; i >= 0; i--) 
            {
                Revesed += input[i];
            }
            int.TryParse(input, out int Before);
            int.TryParse(Revesed,out int Number);
            Console.WriteLine(Number);
            Console.WriteLine(Before==Number?"YES":"NO");
        }

        
    }
}
