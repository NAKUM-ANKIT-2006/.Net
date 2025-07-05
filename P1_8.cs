//Write a program to convert given name in upper characters.
//INPUT: John F Kennedy
//OUTPUT: JOHN F KENNEDY


using System;


namespace CE_BTECH
{
    internal class P1_8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();

            string upperName = name.ToUpper();

            Console.WriteLine("OUTPUT: " + upperName);

            Console.ReadLine();
        }
    }
}
