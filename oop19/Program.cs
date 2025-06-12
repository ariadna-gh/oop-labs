using System;
using System.Collections.Generic;

namespace oop19
{
    internal class Program
    {
        static void Main()
        {
            // мейн завдання 1
            Console.WriteLine("* Транспортна система *");

            Transport[] transports = new Transport[]
            {
                new Car { Name = "Авто" },
                new Bicycle { Name = "Велик" },
                new Train { Name = "Інтерсіті" }
            };
            foreach (var transport in transports)
            {
                transport.Move();
            }

            // мейн завдання 2
            Console.WriteLine("\n * Працівники * ");

            List<Employee> employees = new List<Employee>
            {
                new Programmer { Name = "Андрій" },
                new Designer { Name = "Оксана" },
                new Manager { Name = "Світлана" }
            };
            foreach (var employee in employees)
            {
                employee.Work();
            }
        }

        // завдання 1
        public class Transport
        {
            public string Name { get; set; }

            public virtual void Move()
            {
                Console.WriteLine("Рухається...");
            }
        }
        public class Car : Transport
        {
            public override void Move()
            {
                Console.WriteLine($"{Name} їде по дорозі.");
            }
        }
        public class Bicycle : Transport
        {
            public override void Move()
            {
                Console.WriteLine($"{Name} крутить педалі.");
            }
        }
        public class Train : Transport
        {
            public override void Move()
            {
                Console.WriteLine($"{Name} мчить по рейках.");
            }
        }

        // завдання 2
        public class Employee
        {
            public string Name { get; set; }

            public virtual void Work()
            {
                Console.WriteLine($"{Name} працює.");
            }
        }
        public class Programmer : Employee
        {
            public override void Work()
            {
                Console.WriteLine($"{Name} пише програмний код.");
            }
        }
        public class Designer : Employee
        {
            public override void Work()
            {
                Console.WriteLine($"{Name} створює дизайн.");
            }
        }
        public class Manager : Employee
        {
            public override void Work()
            {
                Console.WriteLine($"{Name} організовує роботу команди.");
            }
        }
    }
}
