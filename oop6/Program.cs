namespace oop6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //завдання 1
            /*
            Console.Write("Введіть число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("Число парне.");
            else
                Console.WriteLine("Число непарне.");
            */


            //завдання 2
            /*
            Console.Write("Введіть вашу оцінку (0-100): ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
                Console.WriteLine("Ваша оцінка: A");
            else if (score >= 75)
                Console.WriteLine("Ваша оцінка: B");
            else if (score >= 60)
                Console.WriteLine("Ваша оцінка: C");
            else
                Console.WriteLine("Ваша оцінка: F");
            */


            //завдання 3
            Console.Write("Введіть число (1-7): ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Понеділок"); break;
                case 2: Console.WriteLine("Вівторок"); break;
                case 3: Console.WriteLine("Середа"); break;
                case 4: Console.WriteLine("Четвер"); break;
                case 5: Console.WriteLine("П’ятниця"); break;
                case 6: Console.WriteLine("Субота"); break;
                case 7: Console.WriteLine("Неділя"); break;
                default: Console.WriteLine("Невірне число!"); break;
            }


        }
    }
}
