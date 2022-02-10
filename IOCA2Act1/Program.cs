using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Joshua Farrell
// ID: M153428
// Date: 10 February 2022
// Program descrption:
// This program reads an input and tests if it is
// equal to a given target value (e.g., 10)

namespace IOCA2Act1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int inputValue;
            int targetValue = 10;

            // Read user input and check if input is an integer
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out inputValue);

            // Test  if it is equal to targetValue
            if (inputValue == targetValue)
            {
                Console.WriteLine("Your number {0} is equal to {1}", inputValue, targetValue);
            }// IF targetValue
            else
            {
                Console.WriteLine("Your number {0} is NOT equal to {1}", inputValue, targetValue);
            }// ELSE targetValue

        }
    }
}
