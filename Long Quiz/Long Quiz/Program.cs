using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Long_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee ID
            Console.Write("ENTER EMPLOYEE ID: ");
            string employeeID = Console.ReadLine();

            // Rate per Day
            decimal ratePerDay = 512;
            Console.WriteLine("THE RATE PER DAY: " + ratePerDay);

            // Number of Days Work
            Console.Write("ENTER NUMBER DAYS WORK: ");
            decimal numberOfDaysWork = decimal.Parse(Console.ReadLine());

            // Basic Pay
            decimal basicPay = ratePerDay * numberOfDaysWork;
            Console.WriteLine("THE BASIC PAY IS: " + basicPay);

            // OT Rate
            decimal otRate = 70;
            Console.WriteLine("THE OT is : " + otRate + " PER HOUR");

            // NUMBER OF OT
            Console.Write("ENTER NUMBER OF OT: ");
            decimal numberOfOT = decimal.Parse(Console.ReadLine());

            // TOTAL OT
            decimal totalOT = otRate * numberOfOT;
            Console.WriteLine("THE TOTAL OT is : " + totalOT);

            // GROSS PAY OT
            decimal grossPay = basicPay + totalOT;
            Console.WriteLine("THE GROSS PAY is : " + grossPay);

            // DEDUCTIONS
            //
            Console.WriteLine("DEDUCTIONS");


            // CASH ADVANCED
            Console.Write("ENTER CASH ADVANCED: ");
            decimal cashAdvanced = decimal.Parse(Console.ReadLine());

            // PHILHEALTH
            Console.Write("ENTER PHILHEALTH: ");
            decimal philhealth = decimal.Parse(Console.ReadLine());

            // CASHBOND
            decimal cashbond = 100;
            Console.WriteLine("THE CASHBOND is : " + cashbond);

            // SSS
            Console.Write("ENTER SSS: ");
            decimal sss = decimal.Parse(Console.ReadLine());

            // PAGIBIG
            Console.Write("ENTER PAGIBIG: ");
            decimal pagibig = decimal.Parse(Console.ReadLine());

            // GSIS
            Console.Write("ENTER GSIS: ");
            decimal gsis = decimal.Parse(Console.ReadLine());

            // TAX
            // "M"stands for literal
            // https://stackoverflow.com/questions/977484/what-does-the-m-stand-for-in-c-sharp-decimal-literal-notation
            decimal tax = 0.15M * grossPay;
            Console.WriteLine("THE TAX is : " + tax);

            // TOTAL DEDUCTION
            decimal totalDeductions = cashAdvanced + philhealth + cashbond + sss + pagibig + gsis + tax;
            Console.WriteLine("THE TOTAL DEDUCTION is : " + totalDeductions);

            // NET PAY
            decimal netPay = grossPay - totalDeductions;
            Console.WriteLine("THE NET PAY is : " + netPay);

            // Pause
            Console.ReadKey();
        }
    }
}
