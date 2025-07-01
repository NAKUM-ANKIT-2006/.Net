using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_BTECH
{
    class P1_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            string str = Console.ReadLine();
            

            int x = Convert.ToInt32(str);

            if (x % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            Console.Read();
        }
    }

}
