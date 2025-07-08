//Write a Program to generate following output
//1
//1 2
//1 2 3
//1 2 3 4


using System;

namespace CE_BTECH
{
    internal class P1_17
    {
       public static void Main()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
