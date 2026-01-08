namespace _3.Part1
{
    /// <summary>
    /// Задача 1. Сумма элементов массива
    /// Напишите программу, которая создает массив из 10 целых чисел 
    /// и выводит на экран их сумму.
    /// </summary>
    public class Task1
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 1: Сумма элементов массива ===\n");

            // Создание массива из 10 целых чисел
            int[] numbers = { 5, 12, 8, 23, 15, 7, 19, 4, 31, 11 };

            Console.WriteLine("Массив чисел:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}");
                if (i < numbers.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            // Вычисление суммы элементов массива
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"\n\nСумма всех элементов массива: {sum}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

