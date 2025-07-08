// Write a program to display a pattern like a right angle triangle using an asterisk

using System;

namespace CE_BTECH
{
    internal class P1_16
    {
        public static void Main()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
