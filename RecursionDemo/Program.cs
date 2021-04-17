using System;

namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialusingLoop.FactorialLoop(5));
            Console.WriteLine(FactorialUsingRecursion.FactorialRecursion(4));

            Console.Read();
        }
    }
}
