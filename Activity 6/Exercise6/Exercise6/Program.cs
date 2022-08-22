// <copyright file="Program.cs" company="BootCamp FY2203">
// Copyright (c) BootCamp FY2203. All rights reserved.
// </copyright>
namespace Exercise6
{
    using System;

    /// <summary>
    /// Class.
    /// </summary>
    public class Program
    {
        public static object Solution { get; protected set; }

        /// <summary>
        /// Class.
        /// </summary>
        /// <param name="args">Main Class.</param>
        public static void Main(string[] args)
        {
            MyMethod();
        }

        /// <summary>
        /// Method.
        /// </summary>
        public static void MyMethod()
        {
            int[] firstArray = { 1, 2, 3 };
            int[] secondArray = { -1, -3, };
            int[] thirdArray = { 1, 3, 6, 4, 1, 2 };
            int[] fourthArray = { 1, 2, 4, 5, 6 };
            int[] fifthArray = { -1, -2, -3, 1, 3 };

            Solution firstSolution = new Solution();
            Console.WriteLine("First Array Contains : 1, 2, 3");

            // This outputs the missing number in the first array which is 4.
            Console.WriteLine("Here's the missing number in the first Array :  " + firstSolution.Method(firstArray));
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Solution secondSolution = new Solution();

            // This outputs the missing number in the second array which is 1.
            Console.WriteLine("Second Array Contains : 1, -3");
            Console.WriteLine("Here's the missing number in the first Array :  " + secondSolution.Method2(secondArray));
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Solution thirdSolution = new Solution();

            // This outputs the missing number in the second array which is 5.
            Console.WriteLine("Third Array Contains : 1, 3, 6, 4, 1, 2");
            Console.WriteLine("Here's the missing number in the first Array :  " + thirdSolution.Method3(thirdArray));
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Solution fourthSolution = new Solution();
            // This outputs the missing number in the second array which is 3.
            Console.WriteLine("Fourth Array Contains : 1, 2, 4, 5, 6");
            Console.WriteLine("Here's the missing number in the first Array :  " + fourthSolution.Method4(fourthArray));
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Solution fifthSolution = new Solution();
            // This outputs the missing number in the fifth array which is 2.
            Console.WriteLine("Fifth Array Contains : -1, -2, -3, 1, 3 ");
            Console.WriteLine("Here's the missing number in the first Array :  " + fifthSolution.Method5(fifthArray));
            Console.WriteLine("\n");
        }
    }
}
