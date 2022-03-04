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

            int positiveNumber;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                bool validNumber = int.TryParse(prompt, out positiveNumber);

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

            List<string> names = new List<string>();

            names.Add("Chad");
            names.Add("Sawyer");
            names.Add("Daniel");
            names.Add("Rose");
            names.Add("Black");
            names.Add("White");
            names.Add("Master");
            names.Add("Coder");
            names.Add("Brantford");
            names.Add("Lou");
            names.Add("Bob");
            names.Add("Sue");
            names.Add("Clark");
            names.Add("Jason");
            names.Add("Carol");
            names.Add("Jim");
            names.Add("Jiffy");
            names.Add("Susan");
            names.Add("Susana");
            names.Add("Box");
            names.Add("philips");
            names.Add("Tate");
            names.Add("Medicant");
            names.Add("Mexican");
            names.Add("shaquisha");
            names.Add("Devon");
            names.Add("Brown");
            names.Add("Blue");
            names.Add("Smith");
            names.Add("Dean");
            names.Add("Mark");
            names.Add("Christian");
            names.Add("Sophie");
            names.Add("Sophia");
            names.Add("Eliza");
            names.Add("Elise");
            names.Add("Alex");
            names.Add("Elan");
            names.Add("Musk");
            names.Add("Bill");
            names.Add("Gates");

            Random generator = new Random();

            int index = generator.Next(0, names.Count);

            string randomName = names[index];
            Console.WriteLine($"Your name(s) is/are {randomName}");

            return null;
        }


    }
}

