using System;
using System.Collections.Generic;
using System.Linq;
namespace oop25
{
    // завдання 1 strategy
    public interface ICalculationStrategy
    {
        int Calculate(int a, int b);
    }
    public class AddStrategy : ICalculationStrategy
    {
        public int Calculate(int a, int b) => a + b;
    }
    public class SubtractStrategy : ICalculationStrategy
    {
        public int Calculate(int a, int b) => a - b;
    }
    public class MultiplyStrategy : ICalculationStrategy
    {
        public int Calculate(int a, int b) => a * b;
    }
    public class Calculator
    {
        private ICalculationStrategy _strategy;
        public Calculator(ICalculationStrategy strategy) => _strategy = strategy;
        public void SetStrategy(ICalculationStrategy strategy) => _strategy = strategy;
        public int Calculate(int a, int b) => _strategy.Calculate(a, b);
    }
    // завдання 2 command 
    public interface ICommand
    {
        void Execute();
    }
    public class OpenFileCommand : ICommand
    {
        public void Execute() => Console.WriteLine("Файл відкрито.");
    }
    public class SaveFileCommand : ICommand
    {
        public void Execute() => Console.WriteLine("Файл збережено.");
    }
    public class CloseFileCommand : ICommand
    {
        public void Execute() => Console.WriteLine("Файл закрито.");
    }
    public class Editor
    {
        public void RunCommand(ICommand command)
        {
            command.Execute();
        }
    }
    // завдання 3 mediator
    public interface IChatMediator
    {
        void Send(string message, User sender);
        void Register(User user);
    }
    public class ChatMediator : IChatMediator
    {
        private List<User> _users = new();
        public void Register(User user) => _users.Add(user);    
        public void Send(string message, User sender)
        {
            foreach (var user in _users.Where(u => u != sender))
                user.Receive(message);
        }
    }
    public class User
    {
        public string Name { get; }
        private IChatMediator _mediator;
        public User(string name, IChatMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }
        public void Send(string message)
        {
            Console.WriteLine($"{Name} надсилає: {message}");
            _mediator.Send(message, this);
        }
        public void Receive(string message)
        {
            Console.WriteLine($"{Name} отримав: {message}");
        }
    }
    // завдання 4 observer
    public interface IObserver
    {
        void Update(string weather);
    }
    public class WeatherStation
    {
        private List<IObserver> _observers = new();
        public void Subscribe(IObserver obs) => _observers.Add(obs);

        public void SetWeather(string newWeather)
        {
            Console.WriteLine($"Погода змінена: {newWeather}");
            foreach (var o in _observers)
                o.Update(newWeather);
        }
    }
    public class PhoneApp : IObserver
    {
        private string _id;
        public PhoneApp(string id) => _id = id;

        public void Update(string weather)
        {
            Console.WriteLine($"[App {_id}] Нова погода: {weather}");
        }
    }
    public class Billboard : IObserver
    {
        private string _location;
        public Billboard(string location) => _location = location;

        public void Update(string weather)
        {
            Console.WriteLine($"[Білборд {_location}] Оновлено: {weather}");
        }
    }
    // клас програми
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" * Strategy * ");
            var calc = new Calculator(new AddStrategy());
            Console.WriteLine("14 + 5 = " + calc.Calculate(14, 5));
            calc.SetStrategy(new SubtractStrategy());
            Console.WriteLine("15 - 8 = " + calc.Calculate(15, 8));
            calc.SetStrategy(new MultiplyStrategy());
            Console.WriteLine("23 * 2 = " + calc.Calculate(23, 2));

            Console.WriteLine("\n * Command * ");
            var editor = new Editor();
            editor.RunCommand(new OpenFileCommand());
            editor.RunCommand(new SaveFileCommand());
            editor.RunCommand(new CloseFileCommand());

            Console.WriteLine("\n * Mediator * ");
            var chat = new ChatMediator();
            var alice = new User("Персона один", chat);
            var bob = new User("Персона два", chat);
            var carol = new User("Персона три", chat);
            chat.Register(alice);
            chat.Register(bob);
            chat.Register(carol);
            alice.Send("Вітаю всіх");
            carol.Send("Доброго дня всім");

            Console.WriteLine("\n * Observer * ");
            var station = new WeatherStation();
            var phone = new PhoneApp("UA001");
            var board = new Billboard("Центр міста");
            station.Subscribe(phone);
            station.Subscribe(board);
            station.SetWeather("Туманно, +18°C");
            station.SetWeather("Дощить, +15°C");
        }
    }
}
