using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Contest_1
{
    internal class C_Next_Alphabet
    {
        public static void Start()
        {
            char input = char.Parse(Console.ReadLine());
            char ascii ;
            if (input== 'z') 
            {
                ascii='a';
            }
            else 
            {
                ascii=(char)(input + 1);
            }
            
            Console.WriteLine(ascii);
        }
    }
}
