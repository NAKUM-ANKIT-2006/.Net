using System;

namespace CE_BTECH
{
    internal class Practice
    {
        public static void Main()
        {
            int a = 5;
            int b = 5;
            int result = a++ + ++b + ++b + ++a + a++ + a++;
            Console.WriteLine("the value of result is: " + result);

            int c = 2;

            switch (c)
            {
                case 1:
                    Console.WriteLine("c is 1");
                    break;
                case 2:
                    Console.WriteLine("c is 2");
                    break;
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Using 2 For Loop");
            Console.WriteLine();


            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Using If.not use 2 time for loop");
            Console.WriteLine();


            for (int i=1; i<=9; i++)
            {
                //int k = i;
                int k;
                if (i <= 5)
                {
                    k = i;
                }
                else
                {
                    k = 10 - i;
                }
                for (int j = 1; j <= k; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Using If.not use 2 time for loop and in 1 line condition");
            Console.WriteLine();


            for (int i = 1; i <= 9; i++)
            {
                int k = i<=5 ? i:10 - i;
                for (int j = 1; j <= k; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}