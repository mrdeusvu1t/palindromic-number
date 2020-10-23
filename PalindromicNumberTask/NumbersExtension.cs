using System;

namespace PalindromicNumberTask
{
    /// <summary>
    /// Provides static method for working with integers.
    /// </summary>
    public static class NumbersExtension
    {
        /// <summary>
        /// Determines if a number is a palindromic number, see https://en.wikipedia.org/wiki/Palindromic_number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <returns>true if the verified number is palindromic number; otherwise, false.</returns>
        /// <exception cref="ArgumentException"> Thrown when source number is less than zero. </exception>
        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("error");
            }

            char[] numbers = number.ToString().ToCharArray();

            var len = numbers.Length - 1;
            for (int i = 0; i < len + 1; i++)
            {
                if (numbers[i] == numbers[len - i])
                {
                    continue;
                }

                if (i == len - i)
                {
                    return true;
                }

                return false;
            }

            return true;
        }
    }
}
