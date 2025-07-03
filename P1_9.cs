using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
