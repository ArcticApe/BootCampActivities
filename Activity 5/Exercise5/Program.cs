// <copyright file="Program.cs" company="BootCamp FY22.03">
// Copyright (c) BootCamp FY22.03. All rights reserved.
// </copyright>

namespace Exercise5
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
            int[] arrayList = new int[10];
            int w, x, y, z;

            // USER IS ASKED TO INPUT THE RANGE OF THE DESIRED ARRAY
            Console.WriteLine("Input the range of your array : ");
            w = Convert.ToInt32(Console.ReadLine());

            // USER IS ASKED BY THE SYSTEM TO INPUT THE DESIRED DIGITS THAT CORRESPONDS TO RANGE OF ARRAY
            Console.Write("Input {0} digits in the array", w);

            for (x = 0; x < w; x++)
            {
                Console.WriteLine("Digit number - {0} : ", x);
                arrayList[x] = Convert.ToInt32(Console.ReadLine());
            }

            // SYSTEM WILL NOW SHOW THE OUTPUT FOR THE ASCENDING ORDER
            Console.WriteLine("\nElements of array in ascending order : \n");
            for (x = 0; x < w; x++)
            {
                Console.WriteLine(" {0}   ", arrayList[x]);
            }

            // FORMULA FOR THE DESCENDING ORDER
            for (x = 0; x < w; x++)
            {
                for (y = x + 1; y < w; y++)
                {
                    if (arrayList[x] < arrayList[y])
                    {
                        z = arrayList[x];
                        arrayList[x] = arrayList[y];
                        arrayList[y] = z;
                    }
                }
            }

            // SYSTEM WILL SHOW THE OUTPUT FOR THE DESCENDING ORDER
            Console.WriteLine("\nElements of array in descending order : \n");
            for (x = 0; x < w; x++)
            {
                Console.WriteLine(" {0}   ", arrayList[x]);
            }

            Console.Write("\n\n");
        }
    }
}