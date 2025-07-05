//Write a Program which accepts no from the user and print the same in words.
//INPUT: 98732
//OUTPUT: Nine Eight Seven Three Two

using System;

namespace CE_BTECH
{
    internal class P1_14
    {
        public static void Main(String[] args)
        {
            string s = "";
            Console.WriteLine("Enter a number :");
            int no = Convert.ToInt32(Console.ReadLine());

            while (no != 0)
            {
                int digit = no % 10;
                if (digit == 0)
                {
                    s += "Zero ";
                }
                else if (digit == 1)
                {
                    s += "One ";
                }
                else if (digit == 2)
                {
                    s += "Two ";
                }
                else if (digit == 3)
                {
                    s += "Three ";
                }
                else if (digit == 4)
                {
                    s += "Four ";
                }
                else if (digit == 5)
                {
                    s += "Five ";
                }
                else if (digit == 6)
                {
                    s += "Six ";
                }
                else if (digit == 7)
                {
                    s += "Seven ";
                }
                else if (digit == 8)
                {
                    s += "Eight ";
                }
                else if (digit == 9)
                {
                    s += "Nine ";
                }
                no = no / 10;
            }
            Console.WriteLine(s);
        }
    }
}
