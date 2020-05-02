using System;
using System.Collections.Generic;
using SortExtensions.Sorters;

namespace SortExtensions
{
    internal static class ValidationHelper
    {
        /// <summary>
        /// Checks if collection is null.
        /// </summary>
        /// <param name="source">Collection</param>
        /// <typeparam name="T">Element type</typeparam>
        /// <exception cref="ArgumentNullException">source is null</exception>
        public static void CheckSource<T>(IEnumerable<T> source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }
        }

        /// <summary>
        /// Checks if sorter is null.
        /// </summary>
        /// <param name="sorter">Implementation of sorting algorithm</param>
        /// <exception cref="ArgumentNullException">sorter is null</exception>
        public static void CheckSorter(ISorter sorter)
        {
            if (sorter is null)
            {
                throw new ArgumentNullException(nameof(sorter));
            }
        }

        /// <summary>
        /// Checks if bounds of range of collection is less than zero.
        /// </summary>
        /// <param name="index">Start index for sorting</param>
        /// <param name="length">Elements count for sorting</param>
        /// <exception cref="ArgumentOutOfRangeException">index or length less than zero</exception>
        public static void CheckRangeBounds(int index, int length)
        {
            if (index < 0 || length < 0)
            {
                var paramName = length < 0 ? nameof(length) : nameof(index);
                var message = $"Param '{paramName}' should not be less than zero.";

                throw new ArgumentOutOfRangeException(paramName, message);
            }
        }

        /// <summary>
        /// Checks if source bounds less than section.
        /// </summary>
        /// <param name="index">Start index for sorting</param>
        /// <param name="length">Elements count for sorting</param>
        /// <param name="sourceLength">Source elements count</param>
        /// <exception cref="ArgumentOutOfRangeException">collection bounds less than section</exception>
        public static void CheckSourceBounds(int index, int length, int sourceLength)
        {
            if (index > sourceLength)
            {
                const string paramName = nameof(index);
                var message = $"Param '{paramName}' is outside the bounds for source.";

                throw new ArgumentOutOfRangeException(paramName, message);
            }

            var maxLength = sourceLength - index;
            if (length > maxLength)
            {
                const string paramName = nameof(length);
                var message = $"Param '{paramName}' is outside the bounds for source.";

                throw new ArgumentOutOfRangeException(paramName, message);
            }
        }
    }
}