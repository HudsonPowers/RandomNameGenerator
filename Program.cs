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
            else
            {
                int num = GetPositiveInt("How many names would you like to generate");

                List<string> firstNames = new List<string>();
                List<string> midNames = new List<string>();
                List<string> lastNames = new List<string>();

                firstNames.Add("Chad");
                firstNames.Add("Sawyer");
                firstNames.Add("Daniel");
                firstNames.Add("Rose");
                firstNames.Add("Black");
                firstNames.Add("White");
                firstNames.Add("Master");
                midNames.Add("Coder");
                midNames.Add("Brantford");
                midNames.Add("Lou");
                midNames.Add("Bob");
                midNames.Add("Sue");
                midNames.Add("Clark");
                midNames.Add("Jason");
                midNames.Add("Carol");
                midNames.Add("Jim");
                midNames.Add("Jiffy");
                midNames.Add("Susan");
                midNames.Add("Susana");
                midNames.Add("Box");
                midNames.Add("philips");
                lastNames.Add("Tate");
                firstNames.Add("Medicant");
                firstNames.Add("Mexican");
                firstNames.Add("shaquisha");
                firstNames.Add("Devon");
                firstNames.Add("Brown");
                lastNames.Add("Blue");
                lastNames.Add("Smith");
                lastNames.Add("Dean");
                lastNames.Add("Mark");
                lastNames.Add("Christian");
                lastNames.Add("Sophie");
                lastNames.Add("Sophia");
                lastNames.Add("Eliza");
                lastNames.Add("Elise");
                lastNames.Add("Alex");
                lastNames.Add("Elan");
                lastNames.Add("Musk");
                lastNames.Add("Bill");
                lastNames.Add("Gates");
              
                Console.WriteLine($"Generating {num} values.");
                while (num > 0)
                {
                    string name = GenerateRandomName(firstNames, midNames, lastNames);
                    Console.WriteLine(name);
                    num = num - 1;
                }
                return;

            }
        }
        // Prompts the user to enter the number of random names to generate
        // Loads a list of possible first names
        // Loads a list of possible middle names
        // Loads a list of possible last names
        // Randomly selects a first, middle, and last name
        // Writes the randomly generated name to the console
        // If more names need to be generated, go to step 5
        // Otherwise, the program exits

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
            if (prompt == null)
            {
                throw new Exception("Cannot display a null prompt");
            }
            int positiveNumber;

            do
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                bool validNumber = int.TryParse(input, out positiveNumber);

                if (validNumber == false)
                {
                    Console.Error.WriteLine($"you did not enter a valid number");
                }
                else if (positiveNumber <= 1)
                {
                    Console.WriteLine("Your number was not a positive number");
                }
            }
            while (positiveNumber <= 1);
            return positiveNumber;

            // 1. validate the prompt is a string
            // 2. Display the prompt
            // 3. Read input from the user
            // 4.if the user entered a non-positive number
            // 4a. display error message
            // 4b. go to step 2
            // 5.Otherwise, return the users input



            // TODO(jcollard 2022-03-04): Here is an example that might be helpful for completing this method: https://jcollard.github.io/IntroToCSharpSite/examples/read-input
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



            Random generator = new Random();

            int firstIndex = generator.Next(0, firstNames.Count);
            int midIndex = generator.Next(0, midNames.Count);
            int lastIndex = generator.Next(0, lastNames.Count);

            string randomName = firstNames[firstIndex] + " " + midNames[midIndex] + " " + lastNames[lastIndex];

            // Console.WriteLine($"Your name(s) is/are {randomName}");

            return randomName;
        }


    }
}

