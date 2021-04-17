using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionDemo
{
    class FactorialUsingRecursion
    {

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
