namespace _3.Part2
{
    /// <summary>
    /// Задача 10. Найти максимальное и минимальное значение
    /// Создайте список целых чисел и найдите максимальное и минимальное значения в этом списке.
    /// </summary>
    public class Task10
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 10: Найти максимальное и минимальное значение ===\n");

            // Создание списка целых чисел
            List<int> numbers = new List<int> { 23, 45, 12, 67, 89, 34, 56, 78, 90, 15, 42, 68 };

            Console.WriteLine("Список чисел:");
            PrintList(numbers);

            // Поиск максимального и минимального значений
            if (numbers.Count > 0)
            {
                int max = numbers.Max();
                int min = numbers.Min();

                // Альтернативный способ (без LINQ)
                int maxManual = numbers[0];
                int minManual = numbers[0];
                foreach (int number in numbers)
                {
                    if (number > maxManual)
                    {
                        maxManual = number;
                    }
                    if (number < minManual)
                    {
                        minManual = number;
                    }
                }

                Console.WriteLine($"\nМаксимальное значение (LINQ): {max}");
                Console.WriteLine($"Минимальное значение (LINQ): {min}");
                Console.WriteLine($"\nМаксимальное значение (вручную): {maxManual}");
                Console.WriteLine($"Минимальное значение (вручную): {minManual}");
            }
            else
            {
                Console.WriteLine("Список пуст!");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }

        /// Вспомогательный метод для вывода списка
        private static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}");
                if (i < list.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}

