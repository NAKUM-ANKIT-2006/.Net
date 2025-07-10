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
        public static void Main(string[] args)
        {
            Console.Write("Input number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = num;
            int old = num;

            for (int i = 0; i < terms - 1; i++)
            {
                old = old * 10 + num; // Generate the next term
                sum += old;
            }

            Console.WriteLine("The Sum is: " + sum);
        }
    }
}
