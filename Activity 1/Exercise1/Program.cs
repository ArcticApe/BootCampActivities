// <copyright file="Program.cs" company="BootCamp FY22.03">
// Copyright (c) BootCamp FY22.03. All rights reserved.
// </copyright>
namespace Exercise1
{
    using System;

    /// <summary>
    /// Class.
    /// </summary>
    public class Program
    {
       private static void Main(string[] args)
        {
            // WELCOME MESSAGE
            Console.WriteLine("Hi! Welcome to my First Activity.");
            Console.WriteLine();
            Console.WriteLine("Please enter your desired number for me to calculate the area and perimeter of the Trapezoid.");
            Console.WriteLine();

            try
            {
                // USER INPUTS FOR THE TRAPEZOID
                Console.WriteLine("Input the base 1 of your Trapezoid");
                int base1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the base 2 of your Trapezoid");
                int base2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the leg 1 of your Trapezoid");
                int leg1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the leg 2 of your Trapezoid");
                int leg2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the Height of your Trapezoid");
                int height = Convert.ToInt32(Console.ReadLine());

                // PERIMETER OF TRAPEZOID FORMULA
                int perimeterTrapezoid = base1 + base2 + leg1 + leg2;
                Console.WriteLine("This is the Perimeter of your Trapezoid " + perimeterTrapezoid);

                // AREA OF TRAPEZOID FORMULA
                int areaofTrapezoid = (base1 + base2) / 2 * height;

                Console.WriteLine("This is the Area of your Trapezoid " + areaofTrapezoid);
            }

                // IF USER ENTERED A NUMBER THAT DIDN'T FIT THE REQUIREMENTS, THIS MESSAGE WILL SHOW UP.
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Your input number cannot be divided by zero, Please try another number that fits the application.");
                }

            Console.Read();
        }
    }
}
