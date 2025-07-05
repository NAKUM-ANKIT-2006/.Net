// Write a Program to prints the following series
//0 1 1 2 3 5 8 13 21 34 55

using System;

namespace CE_BTECH
{
    internal class P1_13
    {
        public static void Main(String[] args)
        {
            int a = 0,b=1,next;
            Console.Write(a+" ");
            Console.Write(b+" ");
            for (int i=0; i<9; i++)
            {
                next = a + b;
                Console.Write(next + " ");
                a = b;
                b = next;
            }
        }
    }
}
