using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static void writeDays(string weekNumber, int start, int end)
        {
            Console.Write("The days of week " + weekNumber + " are: ");
            for (int index = start; index <= end; index++)
            {
                if (index < end)
                {
                    Console.Write(index.ToString() + ", ");
                }
                else
                {
                    Console.Write(index);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the week number: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {

                case "1":
                case "one":
                case "One":
                    writeDays("1", 1, 1);
                    break;
                case "2":
                case "two":
                case "Two":
                    writeDays("1", 2, 8);
                    break;
                case "3":
                case "three":
                case "Three":
                    writeDays("1", 9, 15);
                    break;
                case "4":
                case "four":
                case "Four":
                    writeDays("1", 16, 22);
                    break;
                case "5":
                case "five":
                case "Five":
                    writeDays("1", 23, 29);
                    break;
                case "6":
                case "six":
                case "Six":
                    writeDays("1", 30, 31);
                    break;
                default:
                    Console.WriteLine("You have entered an invalid week number.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
