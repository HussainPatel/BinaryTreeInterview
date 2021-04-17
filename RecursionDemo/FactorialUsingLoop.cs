using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionDemo
{
    class FactorialusingLoop
    {
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
