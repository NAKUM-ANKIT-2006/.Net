using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_BTECH
{
    internal class pattern
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Pattern 1");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("----------------------");
            Console.WriteLine("Pattern 2");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }



            Console.WriteLine("----------------------");
            Console.WriteLine("Pattern 3");
            int rows = 5;

            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------");
            Console.WriteLine("Pattern 4");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
