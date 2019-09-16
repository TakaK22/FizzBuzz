using System;

namespace FizzBuzz
{
    public class FizzBuzz1
    {
        public static string Convert(int number)
        {
            if (number % 3 == 0) return "Fizz";
            if (number % 5 == 0) return "Buzz";
            return number.ToString();
        }
    }
}
