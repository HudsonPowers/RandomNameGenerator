using System;
using System.Collections.Generic;

namespace RandomNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }
        }

        public static void TestAll()
        {
            bool testPositiveInt = TestPositiveInt.RunTest();
            Console.WriteLine($"Test GetPositiveInt(Filename): {testPositiveInt}");

            bool testGenerateRandomName = TestGenerateRandomName.RunTest();
            Console.WriteLine($"Test GenerateRandomName(Filename): {testGenerateRandomName}");
        }

        /// <summary>
        /// Given a prompt to show to the user, displays the prompt then reads
        ///  input from the keyboard until the user enters a positive number.
        ///  If the user enters a non-positive number,
        ///  this method displays an error message and prompts the user again.
        /// </summary>
        /// <param name="prompt">The message to display to the user</param>
        /// <returns>The positive number the user chose</returns>
        public static int GetPositiveInt(string prompt)
        {
            // 1. validate the prompt is a string
            // 2. Display the prompt
            // 3. Read input from the user
            // 4.if the user enterd a non-positive number
            // 4a. display error message
            // 4b. go to step 2
            // 5.Otherwise, return the users input
            return -1;
        }


        /// <summary>
        /// Given a list of first, middle, and last names,
        ///  generate a random name using one entry from each list.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns>returns the randomly generated name</returns>
        public static string GenerateRandomName(List<string> firstNames, List<string> midNames, List<string> lastNames)
        {
            // 1.Create a random number generator
            // 2.Generate a random number, firstIndex, between 0 and firstNames.Count
            // 3.Generate a random number, midIndex, between 0 and midNames.Count
            // 4.Generate a random number, lastIndex, between 0 and lastNames.Count
            // 5.Combine the names together
            // 5a.firstNames[firstIndex] + " " + midNames[midIndex] + " " + lastNames[lastIndex];
            // 6.Return the name

            return null;
        }


    }
}

