namespace oop14
{
    internal class Program
    {
        // завдання 1

        static void Main()
        {
            string[] fileNames = { "log1.txt", "log2.txt", "log3.txt" };
            GenerateLogFiles(fileNames, 10000);
            Task[] tasks = new Task[fileNames.Length];
            for (int i = 0; i < fileNames.Length; i++)
            {
                int index = i;
                tasks[index] = Task.Run(() => ProcessFile(fileNames[index]));
            }
            Task.WaitAll(tasks);

            Console.WriteLine("Обробка файлів завершена!");
        }
        static void GenerateLogFiles(string[] fileNames, int linesPerFile)
        {
            Random rnd = new Random();
            string[] messages = { "Інформація: усе в порядку", "Попередження: щось не так", "Помилка: критична помилка", "Дебаг: крок виконано" };

            foreach (string file in fileNames)
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    for (int i = 0; i < linesPerFile; i++)
                    {
                        string line = (rnd.Next(10) == 0) ? "Щось пішло не так" : messages[rnd.Next(messages.Length)];
                        writer.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("Файли успішно згенеровано!");
        }
        static void ProcessFile(string fileName)
        {
            int errorCount = 0;
            try
            {
                foreach (var line in File.ReadLines(fileName))
                {
                    if (line.Contains("Помил"))
                    {
                        errorCount++;
                    }
                }

                Console.WriteLine($"Файл {fileName}: знайдено {errorCount} помилок.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при обробці {fileName}: {ex.Message}");
            }
        }
    }
}
