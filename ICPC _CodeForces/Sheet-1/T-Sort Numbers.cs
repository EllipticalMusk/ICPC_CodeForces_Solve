using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class T_Solve
    {
        public static void Start() 
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            double[] Elements = new double[parts.Length];
            for (int i = 0; i < parts.Length; i++)
                Elements[i] = double.Parse(parts[i]);

            double[] sorted = Sort(Elements);
            for(int i = 0; i < sorted.Length; i++) 
            {
                Console.WriteLine(sorted[i]);
            }
            Console.WriteLine(); 
            for (int i = 0; i < sorted.Length; i++)
            {
                Console.WriteLine(Elements[i]);
            }

        }
        static double[] Sort(double[]input) 
        {
            double[] arr = (double[])input.Clone();
            for (int i = 0; i < arr.Length-1; i++) 
            {
                int tempIndex = GetMinIndex(arr, i);
                double tempValue = arr[i];
                arr[i] = arr[tempIndex];
                arr[tempIndex] = tempValue;


            }
                return arr;
        }
        static int GetMinIndex(double[]arr,int y) 
        {
            double Max = arr[y];
            int MaxIndex = y;
            for(int i = y; i < arr.Length; i++) 
            {
                if (arr[i] <Max) 
                {
                    Max = arr[i];
                    MaxIndex = i;

                }
            }
            return MaxIndex;



        }

    }
}
