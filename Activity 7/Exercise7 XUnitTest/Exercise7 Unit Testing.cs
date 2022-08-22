// <copyright file="Exercise7 Unit Testing.cs" company="BOOTCAMP FY22.03">
// Copyright (c) BOOTCAMP FY22.03. All rights reserved.
// </copyright>

namespace Exercise7
{
    using System;
    using Exercise6;
    using Xunit;

    /// <summary>
    /// UnitTest1.
    /// </summary>
    public class UnitTest1
    {
        [Fact]
        public void SortedPostive1()
        {
            // correct input scenario
            var Solution = new Solution();
            int[] array = { 1, 2, 3 };
            int expected = 4;
            int actual;

            // incorrect input scenario
            // var Program = new Program();
            // int[] array = { -1, -3 };
            // int expected = 4; 
            // int actual;

            // Act
            actual = Solution.Method(array);

            // Assert
            Assert.Equal(actual, expected);
        }

            /// <summary>
            /// sortedPositive.
            /// </summary>
            ///
        [Fact]
        public void SortedPostive2()
        {
            // correct input scenario
            var Solution = new Solution();
            int[] array = { -1, -3 };
            int expected = 1;
            int actual;

            // incorrect input scenario
            // var Program = new Program();
            // int[] array = { -1, -3 };
            // int expected = 1; // any number aside from 0 and 2
            // int actual;

            // Act
            actual = Solution.Method(array);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void unSortedPostive()
        {
            // correct input scenario
            var Solution = new Solution();
            int[] array = { 1, 3, 6, 4, 1, 2 };
            int expected = 5;
            int actual;

            // incorrect input scenario
            // var Program = new Program();
            // int[] array = { 1, 3, 6, 4, 1, 2};
            // int expected = 5;
            // int actual;

            // Act
            actual = Solution.Method(array);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void SortedPostive3()
        {
            // correct input scenario
            var Solution = new Solution();
            int[] array = { 1, 2, 4, 5, 6 };
            int expected = 3;
            int actual;

            // incorrect input scenario
            // var Program = new Program();
            // int[] array = { 1, 2, 4, 5, 6 };
            // int expected = 4; // any number aside from 3
            // int actual;

            // Act
            actual = Solution.Method(array);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Combination()
        {
            // correct input scenario
            var Solution = new Solution();
            int[] array = { -1, -2, -3, 1, 3 };
            int expected = 2;
            int actual;

            // incorrect input scenario
            // var Program = new Program();
            // int[] array = { -1, -2, -3, 1, 3};
            // int expected = 2; 
            // int actual;

            // Act
            actual = Solution.Method(array);

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}