namespace oop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1: реалізація методу IsEven
            /*
            Console.Write("Задайте преше число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Задайте друге число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Парнісь першого числа:  " + (IsEven(firstNumber)));
            Console.WriteLine("Парність другого числа:  " + (IsEven(secondNumber)));

            static bool IsEven(int number)
            {
                return number % 2 == 0;
            }
            */

            // Завдання 2: реалізація функції Sum
            //цілі числа
            /*
            Console.Write("Задайте перше ціле число: ");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Задайте друге ціле число: ");
            int secondInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Задайте третє ціле число: ");
            int thirdInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Задайте перше число з плаваючою комою: ");
            double firstFloat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Задайте друге число з плаваючою комою: ");
            double secondFloat = Convert.ToDouble(Console.ReadLine());
            // виклик методу Sum
            Console.WriteLine("Сума двох цілих чисел: " + Sum1(firstInt, secondInt));
            Console.WriteLine("Сума трьох цілих чисел: " + Sum2(firstInt, secondInt, thirdInt));
            Console.WriteLine("Сума двох чисел з плаваючою комою: " + Sum3(firstFloat, secondFloat));

            // перевантажений метод для двох цілих чисел
            static int Sum(int a, int b)
            {
                return a + b;
            }

            // перевантажений метод для трьох цілих чисел
            static int Sum(int a, int b, int c)
            {
                return a + b + c;
            }

            // перевантажений метод для двох чисел з плаваючою комою
            static double Sum(double a, double b)
            {
                return a + b;
            }
            */

            // Завдання 3: реалізація функції Swap
            int a = 5;
            int b = 10;

            Console.WriteLine($"До обміну: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"Після обміну: a = {a}, b = {b}");

            static void Swap(ref int x, ref int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
        }

    }
}