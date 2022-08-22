// <copyright file="Program.cs" company="Bootcamp FY22.03">
// Copyright (c) Bootcamp FY22.03. All rights reserved.
// </copyright>

namespace Exercise4
{
    using System;

    /// <summary>
    /// Class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Class.
        /// </summary>
        /// <param name="args">Sample Class.</param>
        public static void Main(string[] args)
        {
            // USER NEEDS TO ENTER A VALUE OF 4 - 10 ONLY
            Console.WriteLine("Enter the base value of your Parallelogram 4 - 10!");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // IF THE USER DIDN'T MEET THE REQUIREMENT, THIS MESSAGE WILL SHOW UP
            if (rows <= 3)
            {
                Console.WriteLine("Sorry, please run the program again and enter a value of 4 - 10 only");
                return;
            }

            // IF THE USER EXCEEDS THE REQUIREMENT, THIS MESSAGE WILL SHOW UP
            if (rows > 10)
            {
                Console.WriteLine("Sorry, please run the program again and enter a value of 4 - 10 only");
                return;
            }

            // IF THE USER INPUT FITS THE REQUIREMENT THE PROGRAM WILL GO THROUGH
            else
            {
                for (int loop1 = 0; loop1 <= rows; loop1++)
                {
                    for (int loop2 = 0; loop2 <= rows - loop1; loop2++)
                    {
                        Console.Write(" ");
                    }

                    for (int loop3 = 0; loop3 < rows; loop3++)
                    {
                        Console.Write("*");
                    }

                    Console.Write("\n");
                }
            }
        }
    }
}
