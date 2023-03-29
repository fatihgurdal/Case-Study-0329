namespace BubbleSort.Library
{
    public class BubbleSortManager
    {
        private readonly List<int> numbers;

        public BubbleSortManager(List<int> numbers)
        {
            this.numbers = numbers;
        }
        public List<int> Sort()
        {
            int tempNumber;
            
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = 0; j < numbers.Count - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        tempNumber = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tempNumber;
                    }
                }
            }
            return numbers;
        }
    }
}