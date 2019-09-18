using System;
using FizzBuzzer;

namespace Fizz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("Hi,welcome to FizzBuzz! What's your name?");
                string first = Console.ReadLine();
                Console.WriteLine($"{first}, please choose a number");
                string name = Console.ReadLine();
                int real = int.Parse(name);
                for (var i = 0; i < real; i++)
                {
                    Console.WriteLine(FizzBuzz.GetNumber(i));
                }
            }

        }
    }
} 
 