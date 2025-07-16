//Write a program to find the sum of the series 5 +55 + 555 + 5555 + .. n terms. 
//Test Data :
//Input the number of terms : 4

//Input number : 5
//Expected Output :
//5 + 55 + 555 + 5555
//The Sum is : 6170


using System;

namespace CE_BTECH
{
    internal class P1_21
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter the number of terms : ");
            int term = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number : ");
            int no = Convert.ToInt32(Console.ReadLine());

            int current = 0;
            int sum = 0;

            for (int i = 1; i <= term; i++)
            {
                current = current * 10 + no;
                Console.Write(current);

                if (i != term)
                {
                    Console.Write(" + ");
                }
                sum += current;
            }
            Console.WriteLine();

            Console.WriteLine("The Sum is : {0}", sum);
            Console.Read();
        }
    }
}