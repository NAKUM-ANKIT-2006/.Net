﻿//Write a program to make such a pattern like a right angle triangle with the number increased by 1.

//The pattern like :

//1
//2 3
//4 5 6
//7 8 9 10

using System;
namespace CE_BTECH
{
    internal class P1_18
    {
        public static void Main()
        {
            int number = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}
