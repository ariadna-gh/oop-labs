using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace oop15
{
    internal class Program
    {
        // завдання 1
        
        static void PrintNumbers()
        {
            for (int i = 1; i <= 500; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void CalculateFactorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"\nФакторіал {n} = {result}");
        }
        static void Main()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Parallel.Invoke(
                () => PrintNumbers(),
                () => CalculateFactorial(10)
            );
            stopwatch.Stop();
            Console.WriteLine($"\nЧас виконання: {stopwatch.ElapsedMilliseconds} мс");
        }
        

        // завдання 2
        //без потокобезпеки
        
        static int counter = 0;

        static void Main()
        {
            Parallel.For(0, 1000, i =>
            {
                counter++; // гонка потоків
            });
            Console.WriteLine($"Неуспішний результат: {counter} (очікується 1000)");
        }
        

        //з потокобезпекою

        static int counter = 0;
        static object locker = new object();
        static void Main()
        {
            Parallel.For(0, 1000, i =>
            {
                lock (locker)
                {
                    counter++;
                }
            });
            Console.WriteLine($"Успішний результат (lock): {counter}");
        }
    }
}
