// <copyright file="Program.cs" company="Bootcamp FY22.03">
// Copyright (c) Bootcamp FY22.03. All rights reserved.
// </copyright>

namespace Exercise3
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
            int starWidth = 0;
            // USER NEEDS TO ENTER A VALUE OF 1 - 20 ONLY
            Console.WriteLine("Enter the height of your Inverted Triangle 1 - 20!");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            // IF THE USER EXCEEDS THE REQUIREMENT THIS MESSAGE WILL SHOW UP
            if (rows > 20)
            {
                Console.WriteLine("Sorry please run the program again and enter a value of 1 - 20 only");
            }

            // IF THE USER INPUTS FITS THE REQUIREMENT THE PROGRAM WILL GO THROUGH
            else
            {
                for (int loop1 = rows; loop1 >= 1; loop1--)
                {
                    for (int loop2 = rows; loop2 > loop1; loop2--)
                    {
                        Console.Write(" ");
                    }

                    for (int loop3 = 1; loop3 < (loop1 * 2); loop3++)
                   {
                       Console.Write("*");
                   }

                    Console.Write("\n");
                }
            }
        }
    }
}
