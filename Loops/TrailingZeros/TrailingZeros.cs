﻿namespace TrailingZeros
{
    using System;
    class TrailingZeros
    {
        const int FIVE = 5;
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            int zeros = 0;
            int powFive = 1;
            int denominator = 0;

            CalculateZeros(number, ref zeros, ref powFive, ref denominator);

            Console.WriteLine("{0}! has {1} trailing zeros.", number, zeros);
        }

        private static void CalculateZeros(int number, ref int zeros, ref int powFive, ref int denominator)
        {
            while (denominator <= number)
            {
                denominator = (int)Math.Pow(FIVE, powFive);
                zeros += number / denominator;
                ++powFive;
            }
        }
    }
}
