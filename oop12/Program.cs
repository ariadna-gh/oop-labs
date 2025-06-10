using System; // Для використання Math.Sqrt та Console

namespace oop12
{
    internal class Program
    {
        // завдання 1
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public double DistanceTo(Point other)
            {
                double deltaX = other.X - this.X;
                double deltaY = other.Y - this.Y;
                return Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
            }

            public void Print()
            {
                Console.WriteLine($"Точка: ({X}, {Y})");
            }
        }

        //завдання 2
        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }
            public Car(string brand, string model)
            {
                Brand = brand;
                Model = model;
            }

            public Car(string brand, string model, int year)
                : this(brand, model)
            {
                Year = year;
            }

            public Car(string brand, string model, int year, string color)
                : this(brand, model, year)
            {
                Color = color;
            }

            public void ShowInfo()
            {
                Console.WriteLine("--- Інформація про автомобіль ---");
                Console.WriteLine($"Марка: {Brand}");
                Console.WriteLine($"Модель: {Model}");
                if (Year != 0)
                {
                    Console.WriteLine($"Рік випуску: {Year}");
                }
                if (!string.IsNullOrEmpty(Color))
                {
                    Console.WriteLine($"Колір: {Color}");
                }
            }
        }

        static void Main(string[] args)
        {
            // виконання завдання 1
            Console.WriteLine("--- Демонстрація структури Point ---");
            Point p1 = new Point(3, 4);
            Point p2 = new Point(0, 0);

            p1.Print();
            p2.Print();
            Console.WriteLine($"Відстань від p1 до p2: {p1.DistanceTo(p2)}");
            Console.WriteLine();

            // виконання завдання 2
            Console.WriteLine("--- Демонстрація класу Car ---");
            Car car1 = new Car("BMW", "X5");
            car1.ShowInfo();
            Car car2 = new Car("Mercedes-Benz", "C-Class", 2020);
            car2.ShowInfo();
            Car car3 = new Car("Audi", "A4", 2023, "Синій");
            car3.ShowInfo();
            Console.ReadKey();
        }
    }
}