using System;


namespace RandomNameGenerator
{
    class TestPositiveInt
    {
        public static bool RunTest()
        {
            Console.WriteLine("Testing GetPositiveInt()");

            Console.WriteLine("First type in -5. This should result in an invalid message.");
            Console.WriteLine("Second type in 4. This should not produce an error");
            int result = Program.GetPositiveInt("How old are you?");
            int expected = 4;
            if (result != expected)
            {
                Console.Error.WriteLine($"Expected -5 but got 4");
                return false;
            }

            Console.WriteLine("First type in -10. This should result in an invalid message.");
            Console.WriteLine("Second type in 2. This should not produce an error");
            result = Program.GetPositiveInt("How many letters in your name?");
            expected = 2;
            if (result != expected)
            {
                Console.Error.WriteLine($"Expected 2 but got {result}");
                return false;
            }

            Console.WriteLine("First type in 27. This should result in an invalid message.");
            Console.WriteLine("Second type in -10. This should not produce an error");
            result = Program.GetPositiveInt("How old are you?");
            expected = -10;
            if (result != expected)
            {
                Console.Error.WriteLine($"Expected -10 but got {result}");
                return false;
                // would this work even though it should not accept a negative number
            }

            Console.WriteLine("First type in Hello World. This should result in an invalid message.");
            Console.WriteLine("Second type in  17. This should not produce an error");
            result = Program.GetPositiveInt("How old are you?");
            expected = 4;
            if (result != expected)
            {
                Console.Error.WriteLine($"Expected 4 but got {result}");
                return false;
            }

            return false;
        }

    }
}