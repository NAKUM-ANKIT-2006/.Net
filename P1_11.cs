using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
