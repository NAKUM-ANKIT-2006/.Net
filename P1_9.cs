// Write a Program to convert given name in toggle case.
//INPUT: JoHn F kEnNedy
//OUTPUT: jOhN f KeNneDY

using System;

namespace CE_BTECH
{
    internal class P1_9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();

            string lowername = name.ToLower();

            Console.WriteLine("OUTPUT: " + lowername);

            Console.ReadLine();
        }
    }
}
