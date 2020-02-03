using System;
using System.Collections.Generic;
using static SortExtensions.Helpers.SwapHelper;

namespace SortExtensions.Sorters.Implementations
{
	/// <summary>
	/// The Selection Sort Algorithm implementation for a generic zero-based collection.
	/// </summary>
	/// <remarks>
	/// Worst-case performance O(n^2).
	/// Best-case performance O(n^2).
	/// To learn more, see https://en.wikipedia.org/wiki/Selection_sort
	/// </remarks>
	public sealed class SelectionSorter : Sorter
	{
		protected override void SortCore<T>(Span<T> sortingData, IComparer<T> comparer)
		{
			// For each iteration increase first index, cause it's already sorted.
			for (var firstIndex = 0; firstIndex < sortingData.Length - 1; firstIndex++)
			{
				// Compare current and next elements, swap if needed.
				// Ascending order sort.
				var minIndex = firstIndex;
				for (var current = firstIndex + 1; current < sortingData.Length; current++)
				{
					if (comparer.Compare(sortingData[minIndex], sortingData[current]) > 0)
					{
						minIndex = current;
					}
				}

				if (firstIndex != minIndex)
				{
					Swap(sortingData, firstIndex, minIndex);
				}
			}
		}
	}
}