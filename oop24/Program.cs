namespace oop24
{
    //завдання 1 Adapter
    public interface INewPrinter
    {
        void Print(string message);
    }
    public class OldPrinter
    {
        public void OldPrint()
        {
            Console.WriteLine("Друк через OldPrinter");
        }
    }
    public class PrinterAdapter : INewPrinter
    {
        private readonly OldPrinter _oldPrinter;

        public PrinterAdapter(OldPrinter oldPrinter)
        {
            _oldPrinter = oldPrinter;
        }

        public void Print(string message)
        {
            Console.WriteLine("Адаптер перекладає запит...");
            _oldPrinter.OldPrint();
            Console.WriteLine($"(Новий текст): {message}");
        }
    }
    //завдання 2 Facade
    public class Engine
    {
        public void Start() => Console.WriteLine("Двигун запущено");
    }
    public class Battery
    {
        public void Start() => Console.WriteLine("Акумулятор працює");
    }
    public class IgnitionSystem
    {
        public void Start() => Console.WriteLine("Запалювання працює");
    }
    public class CarFacade
    {
        private readonly Engine _engine = new();
        private readonly Battery _battery = new();
        private readonly IgnitionSystem _ignition = new();

        public void StartCar()
        {
            Console.WriteLine("Запуск авто...");
            _battery.Start();
            _ignition.Start();
            _engine.Start();
            Console.WriteLine("Авто готове їхати");
        }
    }
    // завдання 3 Decorator
    public interface IWriter
    {
        void Write(string text);
    }
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
    public class TimestampWriter : IWriter
    {
        private readonly IWriter _inner;

        public TimestampWriter(IWriter inner)
        {
            _inner = inner;
        }

        public void Write(string text)
        {
            string stamped = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {text}";
            _inner.Write(stamped);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" * Adapter * ");
            INewPrinter printer = new PrinterAdapter(new OldPrinter());
            printer.Print("Це адаптоване повiдомлення.");

            Console.WriteLine("\n * Facade * ");
            CarFacade car = new CarFacade();
            car.StartCar();

            Console.WriteLine("\n * Decorator * ");
            IWriter writer = new TimestampWriter(new ConsoleWriter());
            writer.Write("Я вiтаю свiт");
        }
    }
}
