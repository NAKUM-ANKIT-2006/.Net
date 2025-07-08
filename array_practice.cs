using System;

namespace CE_BTECH
{
    internal class array_practice
    {
        public static void Main()
        {
            int[] a = new int[5];
            Console.WriteLine("Enter 5 value in the array:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Element {0}: ", i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values in the array:");
            foreach (int i in a)
            {
                Console.Write(" "+i);
            }
        }
    }
}
