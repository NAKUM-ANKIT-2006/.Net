using System;
class Program
{

    public static void Main(string[] args)
    {
        /*
         * *
         * **
         * ***
         * ****
         * */

        Console.WriteLine("1st Pattern");
        Console.WriteLine();
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("2nd Pattern");


        /*
         * 1
         * 1 2
         * 1 2 3
         * 1 2 3 4
         */

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        /* 1
         * 2 2
         * 3 3 3
         * 4 4 4 4
         */

        Console.WriteLine();
        Console.WriteLine("3rd Pattern");
        Console.WriteLine();

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("4th pattern");
        Console.WriteLine();

        /*
         * 1
         * 3 2
         * 4 5 6
         * 10 9 8 7
         * 11 12 13 14 15
         */

        int num = 1;

        for (int i = 1; i <= 5; i++)
        {
            if (i % 2 == 0)
            {
                int end = num + i - 1;
                for (int j = end; j >= num; j--)
                {
                    Console.Write(j + " ");
                }
                num = end + 1;
            }
            else
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("5th Pattern");
        Console.WriteLine();

        for (int i = 1; i <= 5; i++)
        {
            for (int space = 1; space <= 5 - i; space++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= (2 * i) - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("6th Pattern");
        Console.WriteLine();

        int n = 1;

        for (int i = 1; i <= 3; i++)
        {
            for (int space = 1; space <= 5 - i; space++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= (2 * i) - 1; j++)
            {
                Console.Write(n);
                n++;
            }

            Console.WriteLine();
        }

    }


}