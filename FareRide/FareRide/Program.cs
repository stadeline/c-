using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FareRided
{
    class Program
    {
        static void Main(string[] args)
        {
            // FARE RIDE
            Console.Write("ENTER FARE RIDE: ");
            int fareRide = int.Parse(Console.ReadLine());

            // NO. OF KILOMETER
            Console.Write("ENTER NO. OF KILOMETER: ");
            int numberOfKilometer = int.Parse(Console.ReadLine());

            // FARE
            int fare = fareRide * numberOfKilometer;
            Console.WriteLine("YOUR FARE IS: " + fare);

            // NO. OF PASSENGER
            Console.Write("ENTER NO. OF PASSENGER: ");
            int numberOfPassenger = int.Parse(Console.ReadLine());

            // DISCOUNT AMOUNT
            Console.Write("ENTER DISCOUNT AMOUNT: ");
            int discountAmount = int.Parse(Console.ReadLine());

            // NO. OF PASSENGER OUT
            Console.WriteLine("THE NUMBER OF PASSENGER IS: " + numberOfPassenger);

            // FARE
            int totalDiscountedAmount = fare - discountAmount;
            Console.WriteLine("TOTAL DISCOUNTED AMOUNT: " + totalDiscountedAmount);

            // TOTAL FARE
            int totalFare = totalDiscountedAmount * numberOfPassenger;
            Console.WriteLine("TOTAL FARE IS: " + totalFare);


            // Pause
            Console.ReadKey();
        }
    }
}
