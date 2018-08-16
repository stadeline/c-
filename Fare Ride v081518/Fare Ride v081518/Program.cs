using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fare_Ride_v081518
{
    class Program
    {
        public static int validateInt(string query)
        {
        start:
            Console.Write(query);
            int result;
            bool resultValid = int.TryParse(Console.ReadLine(), out result);
            if (resultValid == false)
            {
                Console.WriteLine("Please enter a valid number. Press any key to try again.");
                Console.ReadKey();
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 2);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                goto start;
            }
            else
            {
                return result;
            }

        }
        static void Main(string[] args)
        {

        // Label to go back to in case user inputs something that does not exist.
        home:

            // Clear
            Console.Clear();

            // ENTER TYPE OF PASSENGER: 
            Console.Write("ENTER TYPE OF PASSENGER: ");
            string passengerType = Console.ReadLine();
            // Declare fareRide Variable so we can update it later.
            int fareRide = 0;

            // Update the variables according to the type of passenger.
            switch (passengerType)
            {
                case "S":
                case "s":
                    passengerType = "Student";
                    fareRide = 7;
                    break;
                case "N":
                case "n":
                    passengerType = "Senior";
                    fareRide = 6;
                    break;
                case "P":
                case "p":
                    passengerType = "PWD";
                    fareRide = 5;
                    break;
                case "R":
                case "r":
                    passengerType = "Regular";
                    fareRide = 9;
                    break;
                default:
                    Console.WriteLine("You have entered an invalid Passenger Type. Press any key to try again.");
                    Console.ReadKey();
                    goto home;
            }


        // ENTER STATION CODE: 
        enterStation:
            Console.Write("ENTER STATION CODE: ");
            string stationCode = Console.ReadLine(), destination = "";
            int ridePrice = 0;


            switch (stationCode)
            {
                case "1":
                    destination = "SM";
                    ridePrice = 16;
                    break;
                case "2":
                    destination = "FCM";
                    ridePrice = 8;
                    break;
                case "3":
                    destination = "EVER";
                    ridePrice = 4;
                    break;
                case "4":
                    destination = "PUREGOLD";
                    ridePrice = 2;
                    break;
                case "5":
                    destination = "ROBINSONS";
                    ridePrice = 1;
                    break;
                default:
                    Console.WriteLine("You have entered an invalid Station Code. Press any key to try again.");
                    Console.ReadKey();
                    // Clear last message.
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 2);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    goto enterStation;
            }

            // Space
            Console.WriteLine("");

            Console.WriteLine("YOUR DESTINATION IS: " + destination);
            Console.WriteLine("YOUR FARE IS: " + fareRide);
            int numberOfPassenger = validateInt("ENTER NO. OF PASSENGER: ");

            // Space
            Console.WriteLine("");
            Console.WriteLine("THE NUMBER OF PASSENGER IS:" + numberOfPassenger);
            Console.WriteLine("THANK YOU FOR RIDING:" + passengerType);
            int totalFare = numberOfPassenger * fareRide;
            Console.WriteLine("TOTAL FARE IS:" + totalFare);

            Console.WriteLine("");
            int cash = validateInt("ENTER CASH: ");
            int change = cash - totalFare;
            if (change < 0)
            {
                Console.WriteLine("Please pay the remaining balance of: " + (change * -1));
            }
            else
            {
                Console.WriteLine("YOUR CHANGE IS:" + change);

            }




            // Pause
            Console.ReadKey();
        }
    }
}
