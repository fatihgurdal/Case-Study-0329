using BubbleSort.Library;

namespace BubbleSort.Test
{
    public class SortTest
    {
        [Theory]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(8)]
        [InlineData(20)]
        public void SortRandom(int listCount)
        {
            var random = new Random();
            var list = Enumerable.Range(0, listCount).Select(x => random.Next()).ToList();
            var linqOrdered = list.OrderBy(x => x).ToList();
            BubbleSortManager sortManager = new(list);
            var newList = sortManager.Sort();

            Assert.True(linqOrdered.SequenceEqual(newList));
        }
    }
}