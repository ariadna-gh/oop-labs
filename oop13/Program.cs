using System;
using System.Collections.Generic;

namespace oop13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // завдання 1

            int[] numbers = { 12, 45, 7, 6, 9, 23, 56, 34, 84, 5 };
            Predicate<int> isEven = n => n % 2 == 0;
            int[] evenNumbers = Filter(numbers, isEven);
            Console.WriteLine("Парні числа:");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            // завдання 2

            Order order = new Order();
            order.OrderStatusChanged += OrderStatusChanged;
            order.Status = "Замовлення отримано";
            order.Status = "Відправлено";
            order.Status = "Доставлено";
        }
        static int[] Filter(int[] numbers, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (predicate(number))
                    result.Add(number);
            }
            return result.ToArray();
        }
        static void OrderStatusChanged(object sender, string status)
        {
            Console.WriteLine($"Статус замовлення змінено на: {status}");
        }
    }
    class Order
    {
        public event EventHandler<string> OrderStatusChanged;
        private string status;
        public string Status
        {
            get => status;
            set
            {
                if (status != value)
                {
                    status = value;
                    OnOrderStatusChanged(status);
                }
            }
        }
        protected virtual void OnOrderStatusChanged(string newStatus)
        {
            OrderStatusChanged?.Invoke(this, newStatus);
        }
    }
}
