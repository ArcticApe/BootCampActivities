// <copyright file="Class1.cs" company="BootCamp FY2203">
// Copyright (c) BootCamp FY2203. All rights reserved.
// </copyright>

namespace Exercise6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        /// <summary>
        /// CLASS SOLUTION.
        /// </summary>
        /// <summary>
        ///
        /// </summary>
        /// <param name="parameterA">d.</param>
        /// <returns>Method.</returns>
        public int Method(int[] parameterA)
        {
            if (!parameterA.Contains(1))
            {
                return 1;
            }

            int result = parameterA.Max();
            foreach (var number in parameterA)
            {
                if (number > 0 && number <= result)
                {
                    if (!parameterA.Contains(number + 1))
                    {
                        result = number + 1;
                    }
                }
            }

            return result;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="parameterA">d.</param>
        /// <returns>Method2.</returns>
        public int Method2(int[] parameterA)
        {
            if (!parameterA.Contains(1))
            {
                return 1;
            }

            int result = parameterA.Max();
            foreach (var number in parameterA)
            {
                if (number > 0 && number <= result)
                {
                    if (!parameterA.Contains(number + 1))
                    {
                        result = number + 1;
                    }
                }
            }

            return result;
        }

        public int Method3(int[] parameterA)
        {
            if (!parameterA.Contains(1))
            {
                return 1;
            }

            int result = parameterA.Max();
            foreach (var number in parameterA)
            {
                if (number > 0 && number <= result)
                {
                    if (!parameterA.Contains(number + 1))
                    {
                        result = number + 1;
                    }
                }
            }

            return result;
        }

        public int Method4(int[] parameterA)
        {
            if (!parameterA.Contains(1))
            {
                return 1;
            }

            int result = parameterA.Max();
            foreach (var number in parameterA)
            {
                if (number > 0 && number <= result)
                {
                    if (!parameterA.Contains(number + 1))
                    {
                        result = number + 1;
                    }
                }
            }

            return result;
        }

        public int Method5(int[] parameterA)
        {
            if (!parameterA.Contains(1))
            {
                return 1;
            }

            int result = parameterA.Max();
            foreach (var number in parameterA)
            {
                if (number > 0 && number <= result)
                {
                    if (!parameterA.Contains(number + 1))
                    {
                        result = number + 1;
                    }
                }
            }

            return result;
        }

    }
}