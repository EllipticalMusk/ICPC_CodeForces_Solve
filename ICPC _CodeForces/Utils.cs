using System;
//Utilty Function To help Save Time
namespace ICPC__CodeForces
{
    public static class Utils
    {
        // Print a 1D array
        public static void PrintArray<T>(T[] array, string separator = " ")
        {
            Console.WriteLine(string.Join(separator, array));
        }
        // Print a single value
        public static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
}
