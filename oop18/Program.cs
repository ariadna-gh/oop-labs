using System;
using System.Collections.Generic;

namespace oop18
{
    //клас Program для демонстрації роботи інтерфейсів
    class Program
    {
        static void Main()
        {
            List<IAnimal> animals = new List<IAnimal>
        {
            new Bear(),
            new Mouse()
        };
            foreach (var animal in animals)
            {
                animal.Speak();
                animal.Eat();
                Console.WriteLine();
            }
            Console.WriteLine("Платіжна система");
            Order order1 = new Order(new CreditCard());
            order1.ProcessPayment(654);
            Order order2 = new Order(new PayPal());
            order2.ProcessPayment(985);
            Order order3 = new Order(new ApplePay());
            order3.ProcessPayment(751);
        }
    }

    //завдання 1
    public interface IAnimal
    {
        void Speak();
        void Eat();
    }
    public class Bear : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Ведьмідь гарчить");
        }
        public void Eat()
        {
            Console.WriteLine("Ведмідь їсть мед.");
        }
    }
    public class Mouse : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Миша пищить");
        }

        public void Eat()
        {
            Console.WriteLine("Миша їсть зерно");
        }
    }

    //завдання 2
    public interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
    public class CreditCard : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата кредитною карткою: {amount} грн");
        }
    }
    public class PayPal : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата через PayPal: {amount} грн");
        }
    }
    public class ApplePay : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата через ApplePay: {amount} грн");
        }
    }
    public class Order
    {
        public IPaymentMethod PaymentMethod { get; set; }

        public Order(IPaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Платіж обробляється...");
            PaymentMethod.Pay(amount);
            Console.WriteLine("Платіж завершено.\n");
        }
    }   
}
