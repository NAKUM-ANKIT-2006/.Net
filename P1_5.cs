//Write output of the program. Also write comment for each line for the following code.

using System;

namespace CE_BTECH
{
        class P1_5 //class name
        {
            static void Main(string[] args) //Main method
            {
                int n, fact = 1; // Declare variables

                Console.WriteLine("Enter Number : "); //user input

                string str = Console.ReadLine(); //read input from user

                n = Convert.ToInt32(str); //Convert string to integer

                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }

                Console.WriteLine("Factorial : {0}", fact); // Display the output

                Console.Read();
            }
        }
 }