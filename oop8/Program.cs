namespace oop8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //завдання 1
            
            int[] numbers = { 12, 15, 7, 20, 33, 50, 8, 11, 90, 45 };
            var divisible = numbers.Where(n => n % 3 == 0 || n % 5 == 0);
            int sum = divisible.Sum();

            Console.WriteLine("Числа: " + string.Join(", ", divisible));
            Console.WriteLine("Сума: " + sum);
            

            //завдання 2

            string[] productNames = { "Хліб", "Молоко", "Яблука", "Сир", "Шоколад", "Кава", "Чай" };
            double[] productPrices = { 25.5, 32.0, 45.3, 120.0, 80.0, 150.0, 75.5 };
            double avg = productPrices.Average();
            Console.WriteLine($"Середня ціна: {avg}");
            Console.WriteLine("Товари ціною вище середньої:");
            for (int i = 0; i < productPrices.Length; i++)
            {
                if (productPrices[i] > avg)
                    Console.WriteLine($"{productNames[i]}: {productPrices[i]} грн");
            }
            int minIndex = Array.IndexOf(productPrices, productPrices.Min());
            int maxIndex = Array.IndexOf(productPrices, productPrices.Max());

            Console.WriteLine($"Найдешевший товар: {productNames[minIndex]} — {productPrices[minIndex]} грн");
            Console.WriteLine($"Найдорожчий товар: {productNames[maxIndex]} — {productPrices[maxIndex]} грн");

        }
    }
}
