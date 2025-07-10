//Write a program to make a pyramid pattern with numbers increased by 1.

//    1  
//   2 3 
//  4 5 6
//7 8 9 10

using System;
namespace CE_BTECH
{
    internal class P1_20
    {
        public static void Main()
        {
            int k = 1;
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
        }

    }
}
