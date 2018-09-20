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


            // Track current number
            int counter = 1;

            // Make 5 lines.
            for (int outerIndex = 0; outerIndex <= 4; outerIndex++)
            {
                // Containing 5 numbers of sequential order.
                for (int index = 0; index <= 4; index++)
                {
                    // Convert the int to string so we can check its length.
                    string localCounter = counter.ToString();
                    if (localCounter.Length < 2)
                    {
                        // Preced it by 0 to match the length of the other, higher numbers.
                        // To make sure the shape is even.
                        localCounter = "0" + localCounter;
                    }

                    // Check if we need to break into a new line.
                    if (index < 4)
                    {
                        Console.Write(localCounter);
                    }

                    else
                    {
                        Console.Write(localCounter + "\n");
                    }

                    // Increment the main counter to keep track of the current number.
                    counter++;
                }
            }

            // Pause
            Console.ReadKey();
        }
    }
}
