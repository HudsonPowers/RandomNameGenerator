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
                Console.Error.WriteLine($"Expected 4 but got {result}");
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

            
            Console.WriteLine("First type in -156. This should result in an invalid message.");
            Console.WriteLine("Second type in 27. This should not produce an error");
            result = Program.GetPositiveInt("How many chickens can you eat?");
            expected = 27;
            if (result != expected)
            {
                Console.Error.WriteLine($"Expected 27 but got {result}");
                return false;
            }

            Console.WriteLine("First type in Hello World. This should result in an invalid message.");
            Console.WriteLine("Second type in  17. This should not produce an error");
            result = Program.GetPositiveInt("How old are you?");
            expected = 17;
            if (result != expected)
            {
                Console.Error.WriteLine($"Expected 17 but got {result}");
                return false;
            }

            return true;
        }

    }
}