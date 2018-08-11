using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    // Commonly needed utility functions
    class Utilities
    {

        // Center the cursor
        public void centerCursor()
        {
            // Measure half of the window's width.
            int halfOfConsole = Console.WindowWidth / 2;
            // Move the cursor to the middle of the screen.
            Console.SetCursorPosition(halfOfConsole, Console.CursorTop);
        }

        // Center Write and WriteLine
        // (content to write, write|line)
        public void centerWrite(string content, string type)
        {
            // Center the cursor.
            centerCursor();
            // Check wheter it's a simple write or line.
            if (type == "write")
            {
                Console.Write(content);
            }
            else if (type == "line")
            {
                Console.WriteLine(content);
            }
        }

        // Center ReadLine
        public string centerRead(string query)
        {
            centerWrite(query, "write");
            // Store the result in a string
            string result = Console.ReadLine();
            // Return it as a string.
            return result;
        }

        // Clear Last Line After an Error Message
        public static void clearLastLineAfterError()
        {
            int position = Console.CursorTop - 1;
            // Clear error message.
            Console.SetCursorPosition(Console.CursorLeft, position);
            Console.Write(new string(' ', Console.WindowWidth));
            // Clear input prompt.
            Console.SetCursorPosition(Console.CursorLeft, position - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            // Go back to the cursor where to place the input
            Console.SetCursorPosition(Console.CursorLeft, position - 1);
        }

        // Validate Double
        public double validateDoube(string query)
        {
        // Restart the process.
        start:
            // Get the input from the user.
            string input = centerRead(query);

            // Declare the resulting value.
            double resultingValue;

            //Get the results.
            bool promise = double.TryParse(input, out resultingValue);
            if (promise == false)
            {
                centerWrite("You have entered an invalid number. Please try again.", "line");
                // Pause
                Console.ReadKey();
                // Clear Last Line After an Error Message
                clearLastLineAfterError();
                // Retry getting input.
                goto start;
            }
            else
            {
                return resultingValue;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Utilities class.
            Utilities util = new Utilities();

        // Label for restart.
        getProductCode:

            // Clear the screen.
            Console.Clear();

            // Get the product code from the user.
            // ENTER PRODUCT CODE: 
            string productCode = util.centerRead("ENTER PRODUCT CODE: ");

            //Set initial value of orderPrice to avoid compile errors.
            double orderPrice = 0;

            switch (productCode)
            {
                case "A":
                case "a":
                case "Apple":
                case "apple":
                    // Set Price
                    orderPrice = (double)10;
                    break;
                case "B":
                case "b":
                case "Banana":
                case "banana":
                    // Set Price
                    orderPrice = (double)35;
                    break;
                case "C":
                case "c":
                case "Cherry":
                case "cherry":
                    // Set Price
                    orderPrice = (double)40;
                    break;
                case "O":
                case "o":
                case "Orange":
                case "orange":
                    // Set Price
                    orderPrice = (double)20;
                    break;
                default:
                    // Display an error message.
                    util.centerWrite("You have entered an invalid product code. Press any key to try again.", "line");
                    // Pause
                    Console.ReadKey();
                    // On key press, go to the start label.
                    goto getProductCode;
            }

            // YOUR ORDER PRICE IS: 
            util.centerWrite("YOUR ORDER PRICE IS: " + orderPrice.ToString("C"), "line");

            // ENTER NO. OF ORDER: 
            double numberOfOrder = util.validateDoube("ENTER NO. OF ORDER: ");

            // YOUR BILL IS: 
            double bill = orderPrice * numberOfOrder;
            util.centerWrite("YOUR BILL IS: " + bill.ToString("C"), "line");

            // Pause
            Console.ReadKey();
        }
    }
}
