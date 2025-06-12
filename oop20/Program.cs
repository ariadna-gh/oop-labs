using System;
using System.Collections.Generic;

namespace oop20
{
    internal class Program
    {
        static void Main()
        {
            // мейн завдання 1
            Console.WriteLine(" * Абстрактнi тварини * \n");
            List<Animal> animals = new List<Animal>
            {
            new Cat(),
            new Dog(),
            new Cow()
            };
            foreach (var animal in animals)
            {
                animal.MakeSound();
                animal.Sleep();
                Console.WriteLine();
            }

            // мейн завдання 2
            Console.WriteLine(" * Платiжна система * \n");
            List<PaymentMethod> payments = new List<PaymentMethod>
            {
            new CreditCard(),
            new PayPal(),
            new ApplePay()
            };
            foreach (var method in payments)
            {
                method.Pay(245.78m);
                method.Confirm();
                Console.WriteLine();
            }
        }

        // завдання 1

        public abstract class Animal
        {
            public abstract void MakeSound();
            public void Sleep()
            {
                Console.WriteLine("Тварина спить...");
            }
        }
        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Мяу!");
            }
        }
        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Гав!");
            }
        }
        public class Cow : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Мууу!");
            }
        }

        // завдання 2

        public abstract class PaymentMethod
        {
            public abstract void Pay(decimal amount);

            public void Confirm()
            {
                Console.WriteLine("Платiж пiдтверджено");
            }
        }
        public class CreditCard : PaymentMethod
        {
            public override void Pay(decimal amount)
            {
                Console.WriteLine($"Оплата {amount} через кредитну картку.");
            }
        }
        public class PayPal : PaymentMethod
        {
            public override void Pay(decimal amount)
            {
                Console.WriteLine($"Оплата {amount} через PayPal.");
            }
        }
        public class ApplePay : PaymentMethod
        {
            public override void Pay(decimal amount)
            {
                Console.WriteLine($"Оплата {amount} через Apple Pay.");
            }
        }
    }
}
