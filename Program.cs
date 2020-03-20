using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first1, second2;
            Console.WriteLine("Введите первое число: ");

            while (!int.TryParse(Console.ReadLine(), out first1))
            {
                Console.WriteLine("Введите число");
            }

            Console.WriteLine("Введите второе число: ");

            while (!int.TryParse(Console.ReadLine(), out second2))
            {
                Console.WriteLine("Введите число");
            }

            Task(first1, second2);
        }

        public static void Task(int first1, int second2)
        {
            double answer = Math.Pow(first1 + second2, 2);
            Console.WriteLine($"Ответ = : {answer}");
        }
    }
}