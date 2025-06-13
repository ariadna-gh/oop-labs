using System;

namespace oop21
{
    // мейн завдання 1
    public class Container<T>
    {
        public T Value { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Значення: {Value}, Тип: {Value.GetType().Name}");
        }
    }
    // мейн завдання 2
    public class Finder
    {
        public static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Масив не повинен бути порожнім.");

            T max = array[0];
            foreach (T item in array)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1
            Container<int> intBox = new Container<int> { Value = 42 };
            Container<string> strBox = new Container<string> { Value = "Greetings" };

            Console.WriteLine(" * Узагальнений контейнер * ");
            intBox.ShowInfo();
            strBox.ShowInfo();
            Console.WriteLine(); // розділювач для візуалу

            // Завдання 2
            int[] intArray = { 12, 5, 13, 54, 24 };
            double[] doubleArray = { 2.45, 7.1, 4.8, 6.7 };
            string[] stringArray = { "passhionfruit", "cherry", "mango" };

            Console.WriteLine(" * Узагальнений метод пошуку * ");
            Console.WriteLine("Максимальне значення (int): " + Finder.FindMax(intArray));
            Console.WriteLine("Максимальне значення (double): " + Finder.FindMax(doubleArray));
            Console.WriteLine("Максимальне значення (string): " + Finder.FindMax(stringArray));
        }
    }
}
