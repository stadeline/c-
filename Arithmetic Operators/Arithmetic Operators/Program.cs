using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Employee ID
            int employeeID;
            Console.Write("Enter Employee ID: ");
            employeeID = int.Parse(Console.ReadLine());

            // Rate per day
            int ratePerDay;
            Console.Write("Enter Rate Per Day: ");
            ratePerDay = int.Parse(Console.ReadLine());

            // Number of days worked
            int numberOfDaysWorked;
            Console.Write("Enter Number Of Days Worked: ");
            numberOfDaysWorked = int.Parse(Console.ReadLine());

            // Basic Pay
            int basicPay = ratePerDay * numberOfDaysWorked;
            Console.WriteLine("The basic pay is: " + basicPay);

            // Overtime
            int overTime = 70;
            Console.WriteLine("OT: " + overTime);

            // Number of Overtime
            int numberofOverTime;
            Console.Write("Enter Number of Overtime: ");
            numberofOverTime = int.Parse(Console.ReadLine());

            // Gross Pay
            int grossPay = basicPay + (overTime * numberofOverTime);
            Console.Write("The Gross Pay is: " + grossPay);

            // Pause
            Console.ReadKey();

        }
    }
}
