using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionDemo
{
    class FactorialUsingRecursion
    {
        /// <summary>
        /// Factorial of a number using Recursion
        /// To Multiple the number by number -1 till the number is 1;
        /// example 4! = 4 * 3 * 3 * 1;
        ///         3! = 3 * 2 * 1;
        /// </summary>
        /// <param name="number"></param>
        /// <returns>int</returns>
        public static int FactorialRecursion(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * FactorialRecursion(number - 1);
        }
        
    }
}
