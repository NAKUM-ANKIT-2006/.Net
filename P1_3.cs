//Find out whether the given number is odd or even/

using System;

namespace CE_BTECH
{
    internal class P1_3
    {
        public static void Main(String []args)
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
