using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    public class M_Solve
    {
        public static void Start() 
        {
            char input =char.Parse(Console.ReadLine());
            Solve(input);
        }
        static void Solve(char input) 
        {
            int temp = (int)input;
            if (temp >= 48 && temp <= 57) 
            {
                Console.WriteLine("IS DIGIT");
            }
            else if(temp>=65&&temp<=90){
                Console.WriteLine("ALPHA\nIS CAPITAL");
            }
            else if (temp >= 97 && temp <= 122)
            {
                Console.WriteLine("ALPHA\nIS SMALL");
            }


        }
    }
}
