//Write a Program which accepts name and gender from the user. Here, gender may have only 1 character, M or F.
//Based on the gender prefix the name Mr. & Ms.
//NAME : Hillary Clinton
//GENDER : F

using System;

namespace CE_BTECH
{
    internal class P1_11
    {
        public static void Main(String[]args)
        {
            Console.Write("Enter Name:");
            string name = Console.ReadLine();
            Console.Write("Enter Gender (M/F):");
            string gender = Console.ReadLine();

            if( gender == "M" || gender == "m")
            {
                Console.WriteLine("Hello Mr." + name);
            }
            else if (gender == "F" || gender == "f")
            {
                Console.WriteLine("Hello Ms." + name);
            }
            else
            {
                Console.WriteLine("Please Select Right Gender(M/F)");
            }
        }
    }
}
