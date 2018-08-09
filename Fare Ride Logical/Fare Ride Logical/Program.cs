using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fare_Ride_Logical
{

    // Utility Functions
    class Utilities
    {
        // Center the cursor.
        public void centerCursor()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
        }
        // Write
        public void centerText(string stream)
        {
            centerCursor();
            Console.Write(stream);
        }
        // WriteLine
        public void centerTextLine(string stream)
        {
            centerCursor();
            Console.WriteLine(stream);
        }
        // Number Validation
        public decimal decimalValidation(string query)
        {
        //Output the question
        question:
            centerText(query);
            string input = Console.ReadLine();
            // Track the validity of the input.
            decimal valid;
            // Test it.
            decimal.TryParse(input, out valid);
            // The input is empty 
            if (valid == 0)
            {
                centerTextLine("");
                centerTextLine(input + " is an invalid input. Please enter a number.");
                centerTextLine("");
                goto question;
            }
            else
            {
                return valid;
            }
        }
        // Center Console ReadLine
        public string centerConsoleRead()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
            return Console.ReadLine().ToString();
        }
    }


    class Program
    {



        // Input Validation
        static void Main(string[] args)
        {

            // Other details
            // Use the utility classes defined above.
            Utilities util = new Utilities();

            // Initial values.
            string typeOfPassenger = "0";
            int farePrice = 0;
            decimal discount = 0, numberOfKilometer, numberOfPassenger, fareRide, totalFareRide;

        // Selection Menu
        PassengerSelectionMenu:
            Console.Clear();
            util.centerTextLine("(1)Senior");
            util.centerTextLine("(2)Student");
            util.centerTextLine("(3)Regular\n");
            util.centerText("Enter type of passenger:");
            // Own validation using switch.
            typeOfPassenger = Console.ReadLine();

            // Set the variables based on the selected option.
            // Similar to if (var == "") {
            //  executeCode();
            // }
            switch (typeOfPassenger)
            {
                // Variations of the selected option stacked.
                case "1":
                case "senior":
                case "Senior":
                    util.centerTextLine("");
                    util.centerTextLine("Senior Selected");
                    util.centerTextLine("");
                    farePrice = 8;
                    discount = (decimal).25;
                    break;
                case "2":
                case "student":
                case "Student":
                    util.centerTextLine("");
                    util.centerTextLine("Student Selected");
                    util.centerTextLine("");
                    farePrice = 8;
                    discount = (decimal).20;
                    break;
                case "3":
                case "regular":
                case "Regular":
                    util.centerTextLine("");
                    util.centerTextLine("Regular Selected");
                    util.centerTextLine("");
                    farePrice = 9;
                    discount = 0;
                    break;
                default:
                    util.centerText("You have entered a non-existant type of passenger. Press any key to try again.");
                    Console.ReadKey();
                    goto PassengerSelectionMenu;
            }

            // Make sure we get a number.
            numberOfKilometer = util.decimalValidation("Enter No. of Kilometers:");
            // Make sure we get a number.
            numberOfPassenger = util.decimalValidation("Enter No. of Passenger:");

            // Need to define the initial amount of fareRide first to determine the discounted amount?
            fareRide = numberOfKilometer * farePrice;
            // Then multiply it by the discount factor.
            util.centerTextLine("Passenger discount is: " + ((decimal)discount).ToString("P") + " or " + ((decimal)discount * fareRide).ToString("F"));

            // Discounted Fare Ride?
            fareRide = fareRide - ((decimal)discount * fareRide);
            util.centerTextLine("Your Fare Ride is: " + fareRide.ToString("F"));

            // Total Fare Ride
            totalFareRide = fareRide * numberOfPassenger;
            util.centerTextLine("Total Fare Ride is: " + totalFareRide.ToString("F"));

            util.centerCursor();

            Console.ReadKey();

        }
    }
}
