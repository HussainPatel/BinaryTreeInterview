using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionDemo
{
    class FactorialusingLoop
    {        
        /// <summary>
        /// Factorial of a number using loop
        /// To Multiple the number by number -1 till the number is 1;
        /// example 4! = 4 * 3 * 3 * 1;
        ///         3! = 3 * 2 * 1;
        /// </summary>
        /// <param name="number"></param>
        /// <returns>int</returns>
        public static int FactorialLoop(int number)
        {
            int result = number;

            for (int i = number; i >= 1; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
