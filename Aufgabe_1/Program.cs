using System;
using System.Collections.Generic;

namespace Aufgabe_1
{
    class Program
    {
        // Author: Dirk Mueller
        // Date: 14.03.2021
        //
        // Algorithm:
        // 1. Divide every number between n = 2 and 1000 by the number i fulfilling the condition 2 < i <= n/2
        // 2. If the division has no remainder it is a prime number
        // 3. Print the prime number to the console
        //
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* This program determines the prime numbers between 1 and 1000         *");
            Console.WriteLine("************************************************************************");

            const int UPPERLIMIT = 1000;

            Console.WriteLine("These are the prime numbers between 1 and {0}: ", UPPERLIMIT);

            // Loop through each candidate:
            for (int n = 1; n <= UPPERLIMIT; n++)
            {
                bool moduloZero = false;

                // Loop through all numbers from 2 to i/2 (second half is redundant):
                for (int i = 2; i <= n / 2; i++)
                {
                    // If remainder of division is zero it cannot be a prime number:
                    if (n % i == 0)
                    {
                        // When i is a multiple of j turn the switch to true;
                        moduloZero = true;
                        // Move to the next candidate:
                        break;
                    }
                }

                // If the prime candidate is at least 2 and there was no remainder in the division: 
                if (n > 1 && !moduloZero)
                {
                    if (n >= 100)
                        Console.Write(n + " | ");
                    else if (n >= 10)
                        Console.Write(n + "  | ");
                    else
                        Console.Write(n + "   | ");
                }
            }
            Console.ReadKey();
        }
    }
}