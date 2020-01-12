using SortExtensions.Sorters;
using SortExtensions.Sorters.BubbleSort;
using SortExtensions.Tests.Base;

namespace SortExtensions.Tests.Sorters.BubbleSort
{
    public class BubbleSortEnumerablePositiveTests : BaseSortEnumerablePositiveTests
    {
        public override SortingAlgorithm SortingAlgorithm => SortingAlgorithm.BubbleSort;
        public override ISorter Sorter => new BubbleSorter();
    }
}