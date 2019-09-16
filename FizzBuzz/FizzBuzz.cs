using System;

namespace FizzBuzz
{
    public class FizzBuzz1
    {
        public static string Convert(int number)
        {
            if (number % 3 == 0) return "Fizz";
            return number.ToString();
        }
    }
}
