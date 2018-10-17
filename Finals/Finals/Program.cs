using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    // Items Class
    public class Item
    {
        public string name;
        public int price;
    }


    class Program
    {
        static void Main(string[] args)
        {

            // Login
        login:
            Console.Clear();
            var userNamePrompt = "Enter your username: ";
            var passwordPrompt = "Enter your password: ";
            Console.WriteLine(userNamePrompt);
            Console.WriteLine(passwordPrompt);
            Console.SetCursorPosition(userNamePrompt.Length + 1, 0);
            if (Console.ReadLine() != "")
            {
                goto login;
            }
            Console.SetCursorPosition(passwordPrompt.Length + 1, 1);
            if (Console.ReadLine() != "")
            {
                goto login;
            }
            Console.WriteLine("\nYou have successfully logged in. Press any key to start adding orders.\n");
            Console.ReadKey();
            string currentOrderList = "";
            double totalBill = 0;


            // Add order
        displayStore:
            Console.Clear();
            Item[] storeItems = new Item[]{
            new Item(){name = "Apple iPhone XS", price = 999},
            new Item(){name = "Apple iPhone XS Max", price = 1099},
            new Item(){name = "Apple iPhone XR", price = 749},
            new Item(){name = "Apple 12.9-inch iPad Pro", price = 799},
            new Item(){name = "Apple 10.5-inch iPad Pro", price = 649},
            new Item(){name = "iPad", price = 329},
            new Item(){name = "iPad mini 4", price = 399},
            new Item(){name = "13-inch MacBook Pro", price = 1799},
            new Item(){name = "iMac Pro", price = 4999},
            new Item(){name = "Mac Pro", price = 2999}
            };
            // Display all the products.
            for (int i = 0; i < storeItems.Length; i++)
            {
                Console.WriteLine("[{0}] {1} - ${2}", i + 1, storeItems[i].name, storeItems[i].price);
            }
            // Ask input
            Console.Write("Select a product from the list to add to to the cart: ");
            int selection = 0;
            bool isValidNumber = int.TryParse(Console.ReadLine(), out selection);
            if (isValidNumber == false)
            {
                Console.WriteLine("Please enter a valid number. Press any key to try again");
                Console.ReadKey();
                goto displayStore;
            }
            // Range
            if (selection > storeItems.Length || selection < 1)
            {
                Console.WriteLine("Your selection does not exist. Press any key to try again");
                Console.ReadKey();
                goto displayStore;
            }
            currentOrderList = currentOrderList + "\n" + storeItems[selection - 1].name;
            totalBill += storeItems[selection - 1].price;
            Console.WriteLine("\nCurrent Billing List:\n" + currentOrderList);
            // Get the length of the longest item in the original list
            int storeItemsWidth = 0;
            for (int i = 0; i < storeItems.Length; i++)
            {
                if (storeItemsWidth < storeItems[i].name.Length)
                {
                    storeItemsWidth = storeItems[i].name.Length;
                }
            }
            Console.Write(new string('=', storeItemsWidth));
            Console.WriteLine("\nTotal: " + string.Format("${0:N2}", totalBill));

            //Add another item
        addAnotherSwitch:
            Console.Write("\nWould you like to add another item?(Yes/No)");
            switch (Console.ReadLine())
            {
                case "Yes":
                case "yes":
                case "Y":
                case "y":
                    goto displayStore;
                case "No":
                case "no":
                case "N":
                case "n":
                //Debug
                case "":
                    break;
                default:
                    Console.WriteLine("You have entered an invalid selection. Press any key to try again");
                    Console.ReadKey();
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 2);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 2);
                    goto addAnotherSwitch;
            }

            //Discount
            Console.Write("Enter Discount Percentage: ");
            string discountString = Console.ReadLine();
            double discount = 0;
            bool discountValid = Double.TryParse(discountString, out discount);
            if (discountString == "" || discount <= 0)
            {
                Console.WriteLine("No discount is applied.");
            }
            else if (discountValid)
            {
                totalBill = totalBill - (totalBill * discount / 100);
                string totalBillString = string.Format("${0:N2}", totalBill);
                Console.WriteLine("You have applied a {0}% discount. The discounted total bill is {1}", discount, string.Format("${0:N2}", totalBill));
            }

            // Payment
            Console.WriteLine("\n[1] Cash");
            Console.WriteLine("[2] Credit/Debit Card");
            Console.WriteLine("[3] Check");
        selectPayment:
            Console.Write("Select a payment method:");

            double cash = 0;
            switch (Console.ReadLine())
            {
                case "1":
                enterCash:
                    Console.Write("Enter cash amount: ");
                    bool cashValid = double.TryParse(Console.ReadLine(), out cash);
                    if (cashValid)
                    {
                        double change = cash - totalBill;
                        if (change < 0)
                        {
                            change = change * -1;
                            Console.WriteLine("Your customer's cash is insufficient by ${0}. Press any key to try again.", change);
                            Console.ReadKey();
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.Write(new string(' ', Console.WindowWidth));
                            Console.SetCursorPosition(0, Console.CursorTop - 2);
                            Console.Write(new string(' ', Console.WindowWidth));
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            goto enterCash;
                        }
                        else
                        {
                            Console.WriteLine("Transaction successful. The remaining change is {0}.", string.Format("${0:N2}", change));
                        }
                    }
                    break;
                case "2":
                enterCardNumber:
                    Console.Write("Enter the 16-digit card number:");
                    string cardNumber = Console.ReadLine();
                    double cardNumberDouble;
                    bool cardNumberValid = double.TryParse(cardNumber, out cardNumberDouble);
                    if (cardNumber.Length != 16 || cardNumberValid == false)
                    {
                        Console.WriteLine("You have entered an invalid card number. Press any key to try again.");
                        Console.ReadKey();
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        goto enterCardNumber;
                    }
                    else
                    {
                        Console.WriteLine("Transaction successful.");
                    }
                    break;
                case "3":
                enterBankName:
                    Console.Write("Enter the name of the bank:");
                    string bankName = Console.ReadLine();
                    if (bankName.Length < 1)
                    {
                        Console.WriteLine("Please enter a bank name.");
                        Console.ReadKey();
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        goto enterBankName;
                    }
                enterCheckNumber:
                    Console.Write("Enter the check number:");
                    string checkNumberString = Console.ReadLine();
                    double checkNumber;
                    bool checkNumberValid = double.TryParse(checkNumberString, out checkNumber);
                    if (checkNumberValid == false)
                    {
                        Console.WriteLine("You have entered an invalid check number. Press any key to try again.");
                        Console.ReadKey();
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        goto enterCheckNumber;
                    }
                enterCheckAmount:
                    Console.Write("Enter the amount in the check:");
                    string checkAmountString = Console.ReadLine();
                    double checkAmount;
                    bool checkAmountValid = double.TryParse(checkAmountString, out checkAmount);
                    if (checkAmountValid == false)
                    {
                        Console.WriteLine("You have entered an invalid check amount. Press any key to try again.");
                        Console.ReadKey();
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        goto enterCheckAmount;
                    }
                    double difference = checkAmount - totalBill;
                    if (difference < 0)
                    {
                        difference = difference * -1;
                        Console.WriteLine("The check's amount is insufficient by ${0}. Press any key to try again.", difference);
                        Console.ReadKey();
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        goto enterCheckAmount;
                    }
                    else
                    {

                        Console.WriteLine("Transaction successful. The customer's change is {0}.", string.Format("${0:N2}", difference));
                    }
                    break;
                // Wrong selection.
                default:
                    Console.WriteLine("You have entered an invalid selection. Press any key to try again.");
                    Console.ReadKey();
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 2);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    goto selectPayment;
            }

            // Pause
            Console.ReadKey();
        }
    }
}
