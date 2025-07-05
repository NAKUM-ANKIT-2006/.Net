//Write a Program which accepts mobile no as a string from the user and converts the last 5 digits into X.
//INPUT: 1234567890
//OUTPUT: 12345XXXXX

using System;


namespace CE_BTECH
{
    internal class P1_10
    {
        static void Main()
        {
            Console.Write("Enter mobile number: ");
            string mobile = Console.ReadLine();

            string hide = mobile.Substring(0,5) + "XXXXX";

            Console.WriteLine("Masked Mobile Number: " + hide);
        }
    }

}
