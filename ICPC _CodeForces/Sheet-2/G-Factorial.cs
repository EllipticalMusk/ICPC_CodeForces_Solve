using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_2
{
    internal class G_Factorial
    {
        public static void Start() 
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++) 
            {
                arr[i]=int.Parse(Console.ReadLine()) ;

            }
            for(int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine(fact(arr[i]));
            }
           
            
        }
        static long fact(int x)
        {
            if (x == 0 || x == 1) return 1;
            return x * fact(x-1);
        }
    }
}
