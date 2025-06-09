using System.Text.RegularExpressions;

namespace oop11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // завдання 1

            Queue<string> requests = new Queue<string>();
            bool work = true;
            while (work)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Додати заявку");
                Console.WriteLine("2. Обробити заявку");
                Console.WriteLine("3. Подивитися першу заявку");
                Console.WriteLine("4. Показати всі заявки");
                Console.WriteLine("5. Вийти");
                Console.Write("Виберіть опцію: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Введіть текст заявки: ");
                        string request = Console.ReadLine();
                        requests.Enqueue(request);
                        Console.WriteLine("Заявку додано");
                        break;
                    case "2":
                        if (requests.Count > 0)
                        {
                            string analized = requests.Dequeue();
                            Console.WriteLine($"Заявку \"{analized}\" оброблено");
                        }
                        else
                        {
                            Console.WriteLine("Черга порожня.");
                        }
                        break;
                    case "3":
                        if (requests.Count > 0)
                        {
                            Console.WriteLine($"Перша заявка в черзі: \"{requests.Peek()}\"");
                        }
                        else
                        {
                            Console.WriteLine("Черга порожня.");
                        }
                        break;
                    case "4":
                        if (requests.Count > 0)
                        {
                            Console.WriteLine("Усі заявки:");
                            foreach (var item in requests)
                            {
                                Console.WriteLine($"- {item}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Черга порожня.");
                        }
                        break;
                    case "5":
                        work = false;
                        Console.WriteLine("Програма завершена.");
                        break;
                    default:
                        Console.WriteLine("Введіть коректну опцію.");
                        break;
                }   
            }

            // завдання 2
            /*
            Console.WriteLine("Задайте текст для виконання аналізу:");
        string text = Console.ReadLine();
        string[] words = Regex.Split(text.ToLower(), @"\W+");
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (string.IsNullOrWhiteSpace(word)) continue;

            if (frequency.ContainsKey(word))
                frequency[word]++;
            else
                frequency[word] = 1;
        }
        var sorted = frequency.OrderByDescending(pair => pair.Value);
        Console.WriteLine("\nПомічені повторення слів:");
        foreach (var pairr in sorted)
        {
            Console.WriteLine($"{pairr.Key}: {pairr.Value}");
        }
            */
        }
    }
}
