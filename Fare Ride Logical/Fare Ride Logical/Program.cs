using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fare_Ride_Logical
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initial values.
            string typeOfPassenger = "0";
            int farePrice = 0, numberOfPassenger;
            decimal discount = 0, numberOfKilometer, fareRide, totalFareRide;


            // Selection Menu
            Console.WriteLine("Enter type of passenger:");
            Console.WriteLine("\n\t (1) Senior");
            Console.WriteLine("\t (2) Student");
            Console.WriteLine("\t (3) Regular");
            Console.SetCursorPosition(25, 0);
            typeOfPassenger = Console.ReadLine();

            // Reset cursor
            Console.SetCursorPosition(0, 6);

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
                    Console.WriteLine("Senior Selected\n");
                    farePrice = 8;
                    discount = (decimal).25;
                    break;
                case "2":
                case "student":
                case "Student":
                    Console.WriteLine("Student Selected\n");
                    farePrice = 8;
                    discount = (decimal).20;
                    break;
                case "3":
                case "regular":
                case "Regular":
                    Console.WriteLine("Regular Selected\n");
                    farePrice = 9;
                    discount = 0;
                    break;
            }

            // Other details
            Console.Write("Enter No. of Kilometer:");
            numberOfKilometer = decimal.Parse(Console.ReadLine());

            Console.Write("Enter No. of Passenger:");
            numberOfPassenger = int.Parse(Console.ReadLine());

            // Need to define the initial amount of fareRide first to determine the discounted amount?
            fareRide = numberOfKilometer * farePrice;
            // Then multiply it by the discount factor.
            Console.WriteLine("Passenger discount is: " + (decimal)discount * 100 + "% or " + (decimal)discount * fareRide);

            // Discounted Fare Ride?
            fareRide = fareRide - ((decimal)discount * fareRide);
            Console.WriteLine("Your Fare Ride is: " + fareRide);

            // Total Fare Ride
            totalFareRide = fareRide * numberOfPassenger;
            Console.Write("Total Fare Ride is: " + totalFareRide);

            Console.ReadKey();

        }
    }
}
