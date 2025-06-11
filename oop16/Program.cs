using System;
using System.Threading;
using System.Threading.Tasks;

namespace oop16
{
    class BankAccount
    {
        private int balance = 0;
        private readonly object locker = new();
        public async Task DepositAsync(int amount)
        {
            await Task.Delay(100);
            lock (locker)
            {
                balance += amount;
                Console.WriteLine($"Поповнення +{amount}, поточний баланс: {balance}");
            }
        }
        public async Task WithdrawAsync(int amount)
        {
            await Task.Delay(100);
            lock (locker)
            {
                balance -= amount;
                Console.WriteLine($"Зняття -{amount}, поточний баланс: {balance}");
            }
        }
        public int GetBalance()
        {
            lock (locker)
            {
                return balance;
            }
        }
    }
    class Program
    {
        static async Task Main()
        {
            BankAccount account = new BankAccount();
            Task[] operations = new Task[]
            {
            account.DepositAsync(145),
            account.WithdrawAsync(325),
            account.DepositAsync(654),
            account.WithdrawAsync(45)
            };
            await Task.WhenAll(operations);
            Console.WriteLine($"Фінальний баланс: {account.GetBalance()}");
        }
    }
}
