﻿//Write a program to display a pattern like a diamond. 

//    *  
//   ***   
//  *****
// *******
//*********  
// ******* 
//  *****  
//   ***   
//    *

 

using System;

namespace CE_BTECH
{
    internal class P1_22
    {
        public static void Main(String[] args)
        {
            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}