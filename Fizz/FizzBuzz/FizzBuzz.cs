using System;
namespace FizzBuzzer
{
    public static class FizzBuzz
    {
        public static string GetNumber(int input)
        {
           
                if (input % 3 == 0 && input % 5 == 0)
                    return "FizzBuzz";
                if (input % 3 == 0)
                    return "Fizz";
                if (input % 5 == 0) 
                    return "Buzz";

                return input.ToString();

        }

    }
}
