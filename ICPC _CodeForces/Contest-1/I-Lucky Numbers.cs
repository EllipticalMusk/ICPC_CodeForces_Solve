using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Contest_1
{
    internal class I_Lucky_Numbers
    {
        public static void Start()
        {
            int input = int.Parse(Console.ReadLine());
            int secondDigit = input % 10;
            int firstDigit = (input - secondDigit) / 10;
            if (secondDigit % firstDigit == 00 || firstDigit % secondDigit == 00) 
            {
                Console.WriteLine("YES");
            }
            else 
            {
                Console.WriteLine("NO");
            }

        }
    }
}
