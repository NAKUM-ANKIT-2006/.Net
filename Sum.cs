using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_BTECH
{
    internal class Sum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Addition \n2.Subtraction \n3.Multiplication \n4.Division");
            Console.Write("\nEnter Your Choice:-");
            int a, b;

            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:

                    Console.Write("Enter Number First:-");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Enter Number Second:-");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Addition is :-"+(a+b));
                    break;
                case 2:

                    Console.Write("Enter Number First:-");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Enter Number Second:-");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Subtraction is :-" + (a - b));
                    break;
                case 3:

                    Console.Write("Enter Number First:-");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Enter Number Second:-");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Multilication is :-" + (a * b));
                    break;
                case 4:

                    Console.Write("Enter Number First:-");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Enter Number Second:-");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Division is :-" + (a / b));
                    break;
                default:
                    Console.WriteLine("Invalid Choice! Please select From(1-4).");
                    break;

            }
        }
    }
}
