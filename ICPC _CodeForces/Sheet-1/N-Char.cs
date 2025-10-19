using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    public class N_Solve
    {
        public static void Start() 
        {
            char input = char.Parse(Console.ReadLine());
            Solve(input);
        }
        public static void Solve(char input) 
        {

            if (input >= 'a' && input <= 'z')
            {
                Console.WriteLine(input = (char)(input - 32));
            }
            else if (input >= 'A' && input <= 'Z')
            {
                Console.WriteLine(input = (char)(input + 32));
            }
        }
    }
}
