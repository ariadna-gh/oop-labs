using System;
using System.Collections.Generic;

namespace oop10
{
    internal class Program
    {
        static Queue<MortgageApplication> applications = new Queue<MortgageApplication>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Додати заявку");
                Console.WriteLine("2. Обробити першу заявку");
                Console.WriteLine("3. Переглянути першу заявку");
                Console.WriteLine("4. Переглянути всі заявки");
                Console.WriteLine("5. Вийти");
                Console.Write("Оберіть дію: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Add(); break;
                    case "2":
                        Process(); break;
                    case "3":
                        Peek(); break;
                    case "4":
                        ViewAll(); break;
                    case "5": return;
                    default:
                        Console.WriteLine("Невірний вибір.");
                        break;
                }
            }
        }
        static void Add()
        {
            Console.Write("Введіть суму кредиту (грн): ");
            decimal principal = decimal.Parse(Console.ReadLine());
            Console.Write("Введіть річну відсоткову ставку (%): ");
            decimal annualRate = decimal.Parse(Console.ReadLine());
            Console.Write("Введіть термін (роки): ");
            int years = int.Parse(Console.ReadLine());
            MortgageApplication app = new MortgageApplication(principal, annualRate, years);
            applications.Enqueue(app);
            Console.WriteLine("Заявку додано.");
        }
        static void Process()
        {
            if (applications.Count > 0)
            {
                var app = applications.Dequeue();
                decimal monthlyPayment = app.CalculateMonthlyPayment();
                Console.WriteLine($"Щомісячний платіж: {monthlyPayment} грн");
            }
            else
            {
                Console.WriteLine("Черга пуста.");
            }
        }
        static void Peek()
        {
            if (applications.Count > 0)
            {
                var app = applications.Peek();
                Console.WriteLine("Перша заявка в черзі:");
                Console.WriteLine(app);
            }
            else
            {
                Console.WriteLine("Черга пуста.");
            }
        }
        static void ViewAll()
        {
            if (applications.Count > 0)
            {
                Console.WriteLine("Усі заявки:");
                foreach (var app in applications)
                {
                    Console.WriteLine(app);
                }
            }
            else
            {
                Console.WriteLine("Черга пуста.");
            }
        }
    }
    class MortgageApplication
    {
        public decimal Principal { get; set; }
        public decimal AnnualRate { get; set; }
        public int Years { get; set; }
        public MortgageApplication(decimal principal, decimal annualRate, int years)
        {
            Principal = principal;
            AnnualRate = annualRate;
            Years = years;
        }
        public decimal CalculateMonthlyPayment()
        {
            decimal monthlyRate = AnnualRate / 12 / 100;
            int months = Years * 12;
            if (monthlyRate == 0)
                return Math.Round(Principal / months, 2);
            decimal factor = (decimal)Math.Pow((double)(1 + monthlyRate), months);
            decimal payment = Principal * monthlyRate * factor / (factor - 1);
            return Math.Round(payment, 2);
        }
        public override string ToString()
        {
            return $"Сума: {Principal} грн, Ставка: {AnnualRate}%, Термін: {Years} років";
        }
    }
}
