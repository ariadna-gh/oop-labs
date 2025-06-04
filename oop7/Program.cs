namespace oop7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //завдання 1
            
            for (int i = 2; i <= 20; i += 2)
            {
                Console.Write(i + " ");
            }
            


            //завдання 2
            
            int sum = 0;
            int number;
            Console.WriteLine("Задайте довільну кількість чисел. Для виходу натисніть 0:");
            while (true)
            {
                Console.Write("Введіть число: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                    break;

                sum += number;
            }
            Console.WriteLine("Сума: " + sum);
            


            //завдання 3

            string password;

            do
            {
                Console.Write("Введіть пароль: ");
                password = Console.ReadLine();

                if (password != "11037")
                    Console.WriteLine("Пароль невірний");
            } while (password != "11037");
            Console.WriteLine("Доступ дозволено");

        }
    }
}
