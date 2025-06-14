using System;
namespace oop23
{
    // завдання 1
    // робота з Singleton
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new();
        private Logger() { }
        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    _instance ??= new Logger();
                    return _instance;
                }
            }
        }
        public void Log(string msg)
        {
            Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {msg}");
        }
    }
    // завдання 2
    // робота з Factory Method
    public interface INotification
    {
        void Send(string message);
    }
    public class EmailNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"Email: {message}");
    }
    public class SMSNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"SMS: {message}");
    }
    public class PushNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"Push: {message}");
    }
    public class NotificationFactory
    {
        public static INotification Create(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotification(),
                "sms" => new SMSNotification(),
                "push" => new PushNotification(),
                _ => throw new ArgumentException("Невідомий тип повідомлення")
            };
        }
    }
    // завдання 3
    // робота з Builder
    public class Computer
    {
        public string CPU { get; private set; }
        public string GPU { get; private set; }
        public int RAM { get; private set; }
        public int SSD { get; private set; }
        internal Computer(string cpu, string gpu, int ram, int ssd)
        {
            CPU = cpu;
            GPU = gpu;
            RAM = ram;
            SSD = ssd;
        }
        public void Show()
        {
            Console.WriteLine($"Комп'ютер: CPU={CPU}, GPU={GPU}, RAM={RAM}GB, SSD={SSD}GB");
        }
    }
    public class ComputerBuilder
    {
        private string _cpu;
        private string _gpu;
        private int _ram;
        private int _ssd;
        public ComputerBuilder SetCPU(string cpu)
        {
            _cpu = cpu;
            return this;
        }
        public ComputerBuilder SetGPU(string gpu)
        {
            _gpu = gpu;
            return this;
        }
        public ComputerBuilder SetRAM(int ram)
        {
            _ram = ram;
            return this;
        }
        public ComputerBuilder SetSSD(int ssd)
        {
            _ssd = ssd;
            return this;
        }
        public Computer Build()
        {
            return new Computer(_cpu, _gpu, _ram, _ssd);
        }
    }
    // класс програми
    internal class Program
    {
        static void Main()
        {
            // Singleton
            Logger.Instance.Log("Початок програми");
            Logger.Instance.Log("Це повідомлення з логера");
            Console.WriteLine("\n * Factory Method * ");
            Console.Write("Введіть тип повідомлення (email/sms/push): ");
            string type = Console.ReadLine()?.ToLower() ?? "";
            try
            {
                INotification notification = NotificationFactory.Create(type);
                notification.Send("Я вітаю користувача");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            Console.WriteLine("\n * Builder * ");
            Computer gamingPC = new ComputerBuilder()
                .SetCPU("Intel i7")
                .SetGPU("RTX 3060")
                .SetRAM(32)
                .SetSSD(1000)
                .Build();
            Computer officePC = new ComputerBuilder()
                .SetCPU("Intel i5")
                .SetGPU("Intel UHD")
                .SetRAM(16)
                .SetSSD(512)
                .Build();
            gamingPC.Show();
            officePC.Show();
            Logger.Instance.Log("Роботу завершено");
        }
    }
}
