using System;

namespace oop17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Аріадна";
            student.Age = 18;
            Console.WriteLine($"Ім'я: {student.Name}, Вік: {student.Age}");
            student.Age = -6;
            Console.WriteLine();
            Car car = new Car();
            car.Accelerate(70);
            car.Brake(32);
            car.Brake(65);
            car.Accelerate(-3);
            car.Brake(-2);
        }

        // завдання 1
        public class Student
        {
            private string name;
            private int age;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Age
            {
                get { return age; }
                set
                {
                    if (value >= 0 && value <= 120)
                    {
                        age = value;
                    }
                    else
                    {
                        Console.WriteLine("Некоректний вік. Вік має бути від 0 до 120.");
                    }
                }
            }
        }

        // завдання 2
        public class Car
        {
            private int speed;
            public int Speed
            {
                get { return speed; }
            }
            public void Accelerate(int amount)
            {
                if (amount > 0)
                {
                    speed += amount;
                    Console.WriteLine($"Прискорення: швидкість = {speed}");
                }
                else
                {
                    Console.WriteLine("Помилка: неможливо прискорити на від'ємну величину.");
                }
            }
            public void Brake(int amount)
            {
                if (amount > 0)
                {
                    if (speed - amount < 0)
                    {
                        speed = 0;
                        Console.WriteLine("Автомобіль зупинено.");
                    }
                    else
                    {
                        speed -= amount;
                        Console.WriteLine($"Гальмування: швидкість = {speed}");
                    }
                }
                else
                {
                    Console.WriteLine("Помилка: гальмування має бути додатним.");
                }
            }
        }
    }
}
