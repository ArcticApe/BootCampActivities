// <copyright file="Program.cs" company="BootCamp FY22.03">
// Copyright (c) BootCamp FY22.03. All rights reserved.
// </copyright>
namespace Exercise_2
{
    using System;

    /// <summary>
    /// Class.
    /// </summary>
    public class Program
    {
       private static void Main(string[] args)
        {
            string asterisk = " ";
            //USER NEEDS TO INPUT 1 - 10 ONLY
            Console.WriteLine("Enter the height of your Isosceles 1 - 10!");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            if (height > 10)
            {//IF THE USER ENTER EXCEEDS THE REQUIREMENT THIS MESSAGE WILL SHOW UP
                Console.WriteLine("Sorry please run the program again and enter 1 - 10 only");

            }
            else
            {//IF THE USER INPUTS FITS THE REQUIREMENT THE PROGRAM WILL GO THROUGH
            for (int starWidth = 0; starWidth <= height; starWidth++)
            {
                asterisk += "*";
                Console.WriteLine(asterisk);
            }
            }

            Console.ReadKey();
        }
    }
}
