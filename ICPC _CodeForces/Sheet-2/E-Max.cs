using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class E_Max
    {
        public static void Start() {

            int input=int.Parse(Console.ReadLine());
            string input2 = Console.ReadLine();
            string[] arr = input2.Split(' ');
            int []n=new int[arr.Length];
            for(int i=0;i<input;i++) 
            {
                n[i] = int.Parse(arr[i]); 
            }
            int Max = n[0];
            for(int i = 0; i < n.Length; i++) {
                if (Max < n[i])
                    Max = n[i];

            }
            Console.WriteLine(Max);
        }
    }
}
