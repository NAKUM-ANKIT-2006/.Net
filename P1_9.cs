// Write a Program to convert given name in toggle case.
//INPUT: JoHn F kEnNedy
//OUTPUT: jOhN f KeNneDY

using System;

namespace CE_BTECH
{
    internal class P1_9
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            string newinput = "";

            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                    newinput += char.ToLower(ch);
                else if (char.IsLower(ch))
                    newinput += char.ToUpper(ch);
                else
                    newinput += ch;
            }

            Console.WriteLine("OUTPUT: " + newinput);
            Console.Read();
        }
    }
}