/*
 Author: Tyler Wildrick
 Date: September 17, 2020
 Comments: This C# Console application code uses conditional statements to inform the user
 of their letter grade after entering a number grade (0-100)
*/

using System;
using System.Runtime.CompilerServices;

namespace TechProj2b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Enter the grade you expect to get in ISM 4300 (on a 100 point scale) ...");
            /*
               Try catch block will validate user input, if user does not provide integer or decimal
               the catch block will handle & display error in message. 
            */
            try
            {
                /*
                    This variable will store the user input after parsing into decimal
                */
                string input = Console.ReadLine();
                // This will be used to conver user input into variable
                decimal grade = decimal.Parse(input);
                /* 
                   This IF/ELSE IF/ELSE statement will conditionally test the users input.
                   Various options for the letter grades are available depending on the number 
                   grade entered by the user.
                */
                if (grade >= 90 && grade <= 100)
                {
                    Console.WriteLine("You're letter grade will be an A");
                }

                else if (grade >= 80 && grade < 90)
                {
                    Console.WriteLine("You're letter grade will be a B");

                }

                else if (grade >= 70 && grade < 80)
                {
                    Console.WriteLine("You're letter grade will be a C");

                }

                else if (grade >= 60 && grade < 70)
                {
                    Console.WriteLine("You're letter grade will be D");

                }

                else if (grade >= 0 && grade < 60)
                {
                    Console.WriteLine("You're letter grade will an F");
                }

                else
                {
                    Console.WriteLine("Press any key to exit the program and try again by entering a number between 0 and 100");
                    Console.ReadKey(true);
                }
            } // End of Try
            catch
            {
                Console.WriteLine("Press any key to exit the program and try again by entering a number between 0 and 100");
                Console.ReadKey(true);
            } // End of Catch
        } // End of Main
    } // End of Class
} // End of Namespace
