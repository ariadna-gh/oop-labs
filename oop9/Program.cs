namespace oop9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int BubbleSortWithCount(int[] arr)
            {
                int n = arr.Length;
                int swapCount = 0;
                bool swapped;

                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            // обмін значень, підрахунок перестановки
                            (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                            swapCount++;
                            swapped = true;
                        }
                    }
                    // завершення при відсутності обмінів
                    if (!swapped)
                        break;
                }

                return swapCount;
            }
            static void Main()
            {
                int[] numbers = { 8, 5, 2, 9, 1, 5, 6 };
                int swaps = BubbleSortWithCount(numbers);
                Console.WriteLine($"Кількість перестановок: {swaps}");
                Console.WriteLine("Після сортування: [" + string.Join(", ", numbers) + "]");
            }
        }
    }
}
    