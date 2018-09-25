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
            // Easier to manipulate the diamond this way.
            int rows = 5;
            int mainCounter = 1;
            // Draw a Triangle.
            // Rows
            // 4 Rows
            for (int i = 1; i <= rows; i++)
            {
                // Set the cursor.
                Console.SetCursorPosition(rows - i, Console.CursorTop);
                // Numbers
                // Should loop while incrementing the number of rows for each line.
                for (int j = 1; j <= i; j++)
                {

                    // Check whether we are writing the last number.
                    if (j == i)
                    {
                        Console.Write(mainCounter);
                    }
                    else
                    {
                        Console.Write(mainCounter.ToString() + "*");
                    }
                    // Keep track of the current count.
                    mainCounter++;
                }
                // Seperate the line each time the loop closes.
                Console.WriteLine("");
            }

            //
            //
            //
            // Reverse
            //
            //
            //

            // 4 Rows
            for (int i = rows; i >= 1; i--)
            {
                // Set the cursor.
                Console.SetCursorPosition(rows - i, Console.CursorTop);
                // Numbers
                // Should loop while incrementing the number of rows for each line.
                for (int j = 1; j <= i; j++)
                {

                    // Check whether we are writing the last number.
                    if (j == i)
                    {
                        Console.Write(mainCounter);
                    }
                    else
                    {
                        Console.Write(mainCounter.ToString() + "*");
                    }
                    // Keep track of the current count.
                    mainCounter++;
                }
                // Seperate the line each time the loop closes.
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
