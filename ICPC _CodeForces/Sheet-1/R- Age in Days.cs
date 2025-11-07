using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class R__Age_in_Days
    {
        public static void Start() 
        {
            int.TryParse(Console.ReadLine(), out int Day);
            int years = Day / 365;
            int Remaning_Days=Day% 365;
            int Months = Remaning_Days / 30;
            int Days = Remaning_Days % 30;
            Console.WriteLine($"{years} years\r\n{Months} months\r\n{Days} days\r\n"
                );

        }
    }
}
