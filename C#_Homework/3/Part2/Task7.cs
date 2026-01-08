namespace _3.Part2
{
    /// <summary>
    /// Задача 7. Поиск дубликатов в списке
    /// Напишите программу, которая создает список чисел и определяет, 
    /// есть ли в нем дубликаты. Используйте HashSet для хранения уникальных чисел.
    /// </summary>
    public class Task7
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 7: Поиск дубликатов в списке ===\n");

            // Создание списка чисел путем ввода от пользователя до пустой строки
            List<int> numbers = new List<int>();
            Console.WriteLine("Введите числа (пустая строка для завершения ввода):");

            int inputCount = 1;
            while (true)
            {
                Console.Write($"Число {inputCount}: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break; // Пустая строка - завершение ввода
                }

                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                    inputCount++;
                }
                else
                {
                    Console.WriteLine("Ошибка: введено некорректное значение! Попробуйте снова.");
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("\nСписок пуст. Нет чисел для проверки.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nИсходный список чисел:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]}");
                if (i < numbers.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            // Использование HashSet для поиска дубликатов
            HashSet<int> seen = new HashSet<int>();
            List<int> duplicates = new List<int>();

            foreach (int number in numbers)
            {
                // Если число уже есть в HashSet, значит это дубликат
                if (!seen.Add(number))
                {
                    // Добавляем дубликат только один раз
                    if (!duplicates.Contains(number))
                    {
                        duplicates.Add(number);
                    }
                }
            }

            // Вывод результатов
            Console.WriteLine("\n\n=== РЕЗУЛЬТАТЫ ===");
            if (duplicates.Count == 0)
            {
                Console.WriteLine("Дубликатов не найдено. Все числа уникальны.");
            }
            else
            {
                Console.WriteLine($"Найдено дубликатов: {duplicates.Count}");
                Console.WriteLine("Дублирующиеся числа:");
                foreach (int duplicate in duplicates)
                {
                    int count = numbers.Count(n => n == duplicate);
                    Console.WriteLine($"  {duplicate} (встречается {count} раз(а))");
                }
            }

            Console.WriteLine($"\nУникальных чисел: {seen.Count}");
            Console.WriteLine($"Всего чисел в списке: {numbers.Count}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

