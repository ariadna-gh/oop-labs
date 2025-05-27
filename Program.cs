namespace oop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // завдання 1. Виведення даних різних типів на консоль
            /*
            int age = 25;
            double weight = 72.5;
            char grade = 'A';
            bool isStudent = true;
            string name = "Олександр";

            Console.WriteLine($"Вік: " + age);
            Console.WriteLine($"Вага: " + weight + " кг");
            Console.WriteLine($"Оцінка: " + grade);
            Console.WriteLine($"Студент: " + (isStudent ? "Так" : "Ні"));
            Console.WriteLine($"Ім'я: " + name);

            Console.WriteLine("\nНатисніть Enter для завершення програми");
            Console.ReadLine();
            */

            // завдання 2. перетворення типів даних
            /*
            //запит на double
            Console.Write("Введість число (double): ");
            string input = Console.ReadLine();

            //перетворення із string у double
            double doubleValue  = Convert.ToDouble(input);
            Console.WriteLine("Double: " + doubleValue);

            //перетворення із double у int
            int intValue = (int)doubleValue;
            Console.WriteLine("Int: " + intValue);

            //перетворення із int у string
            string stringValue = intValue.ToString();
            Console.WriteLine("String: " + stringValue);

            
            */

            //завдання 3. консольний ввід/вивід
            /*
            Console.Write("Введіть ваше ім'я: ");
            string name = Console.ReadLine();

            Console.Write("Введіть ваш вік: ");
            string ageInput = Console.ReadLine();
            int age = int.Parse(ageInput);

            Console.Write("Введіть ваш зріст (у см): ");
            string heightInput = Console.ReadLine();
            double height = double.Parse(heightInput);

            Console.WriteLine("\nВаша інформація:");
            Console.WriteLine($"Ім'я: {name}");
            Console.WriteLine($"Вік: {age} років");
            Console.WriteLine($"Зріст: {height} см");
            */

            // завдання 4. обчислення середньої швидкості
            /*
            Console.Write("Введіть відстань (в км): ");
            string distanceInput = Console.ReadLine();
            double distance = double.Parse(distanceInput);

            Console.Write("Введіть час (в годинах): ");
            string timeInput = Console.ReadLine();
            double time = double.Parse(timeInput);

            double speed = distance / time;

            Console.WriteLine($"Середня швидкість: {speed} км/год");
            */

            // завдання 5. робота з рядками
            Console.WriteLine("Введіть речення:");
            string input = Console.ReadLine();

            Console.WriteLine($"Довжина речення: {input.Length} символів");
            Console.WriteLine($"Речення в верхньому регістрі: {input.ToUpper()}");
            
            string replaced = input.Replace(" ", "_");
            Console.WriteLine($"Зміненіпробіли: { replaced}");

            string firstFive = input.Length >= 5 ? input.Substring(0, 5) : input;
            Console.WriteLine($"Перші 5 символів: {firstFive}");

        }


    }
}
