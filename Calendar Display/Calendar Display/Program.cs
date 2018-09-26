using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        // Define global spacer values.
        public static string spacerLarge = "   ";
        public static string spacerSmall = "  ";
        // Count the length of the default space.
        public static int spacerCount = spacerLarge.Length;
        // Seperate method for writing numbers.
        // Accounts for uneven spacing that happens when the date becomes two digits.
        // Takes one arguement which is the value to be displayed.
        public static void displayDate(int numberValue)
        {
            if (numberValue < 10)
            {
                Console.Write(numberValue.ToString() + spacerLarge);
            }
            else
            {
                Console.Write(numberValue.ToString() + spacerSmall);

            }
        }
        // A method which displays the month.
        // lastDate = Last date in said month.
        // dayMonthStarts = The day the month starts. 0=Sunday, 6=Saturday.
        public static void displayMonth(int dayMonthStarts, int lastDate)
        {
            // The number of days in a week declared here for easier calculations.
            int numberOfDaysInAWeek = 7;
            // Calculate the number of days in the first week.
            int daysInFirstWeek = numberOfDaysInAWeek - dayMonthStarts;
            // Display the days with the space.
            Console.Write("S" + spacerLarge);
            Console.Write("M" + spacerLarge);
            Console.Write("T" + spacerLarge);
            Console.Write("W" + spacerLarge);
            Console.Write("T" + spacerLarge);
            Console.Write("F" + spacerLarge);
            Console.Write("S" + spacerLarge);
            // Next line to start writing the dates.
            Console.WriteLine();
            // Start at the the day the month starts.
            // Start at the very left(0) plus the day months starts (0-6) multiplied by the default spacer plus 1(to account for the character typed for the day of the week.).
            Console.SetCursorPosition(Console.CursorLeft + dayMonthStarts * (spacerCount + 1), Console.CursorTop);
            // Date always starts at 1.
            for (int index = 1; index <= lastDate; index++)
            {
                // Check if the first week has ended.
                // Check the second to the fourth week by adding 7 days each time.
                if (index == daysInFirstWeek || index == daysInFirstWeek + numberOfDaysInAWeek || index == daysInFirstWeek + numberOfDaysInAWeek * 2 || index == daysInFirstWeek + numberOfDaysInAWeek * 3)
                {
                    // Pass on the current date to the method which writes out the number with the correct spacing.
                    displayDate(index);
                    // Write a new line since it's the end of the week.
                    Console.WriteLine();
                }
                // The week has not ended. Simply write the date with the correct spacing.
                else
                {
                    displayDate(index);
                }
            }
        }
        static void Main(string[] args)
        {
            // Get the user input.
            Console.Write("Input a month code: "); string inMonth = Console.ReadLine();
            // Determine the month chosen.
            switch (inMonth)
            {
                case "J":
                case "j":
                    Console.WriteLine("\nYou have chosen JANUARY.\n");
                    displayMonth(1, 31);
                    break;
                case "F":
                case "f":
                    Console.WriteLine("\nYou have chosen FEBRUARY.\n");
                    displayMonth(4, 28);
                    break;
                case "M":
                case "m":
                    Console.WriteLine("\nYou have chosen MARCH.\n");
                    displayMonth(4, 31);
                    break;
                case "A":
                case "a":
                    Console.WriteLine("\nYou have chosen APRIL.\n");
                    displayMonth(0, 30);
                    break;
                case "Ma":
                case "ma":
                    Console.WriteLine("\nYou have chosen MAY.\n");
                    displayMonth(2, 31);
                    break;
                case "JU":
                case "ju":
                    Console.WriteLine("\nYou have chosen JUNE.\n");
                    displayMonth(5, 30);
                    break;
                case "JUL":
                case "jul":
                    Console.WriteLine("\nYou have chosen JULY.\n");
                    displayMonth(0, 31);
                    break;
                case "AU":
                case "au":
                    Console.WriteLine("\nYou have chosen AUGUST.\n");
                    displayMonth(3, 31);
                    break;
                case "S":
                case "s":
                    Console.WriteLine("\nYou have chosen SEPTEMBER.\n");
                    displayMonth(6, 30);
                    break;
                case "O":
                case "o":
                    Console.WriteLine("\nYou have chosen SEPTEMBER.\n");
                    displayMonth(1, 31);
                    break;
                case "N":
                case "n":
                    Console.WriteLine("\nYou have chosen NOVEMBER.\n");
                    displayMonth(4, 30);
                    break;
                case "D":
                case "d":
                    Console.WriteLine("\nYou have chosen DECEMBER.\n");
                    displayMonth(6, 31);
                    break;
                default:
                    Console.Write("YOU have entered an invalid month. Please run the program again.");
                    break;
            }

            // Pause
            Console.ReadKey();
        }
    }
}
