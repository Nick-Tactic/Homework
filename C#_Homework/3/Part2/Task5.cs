namespace _3.Part2
{
    /// <summary>
    /// Задача 5. Набор уникальных чисел
    /// Напишите программу, которая использует набор (хэш сет) для хранения уникальных чисел, 
    /// введенных пользователем. Цикл на 10 вводов пользователя. 
    /// Выводите все уникальные числа после завершения ввода.
    /// </summary>
    public class Task5
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 5: Набор уникальных чисел ===\n");
            Console.WriteLine("Введите 10 чисел (повторяющиеся числа будут сохранены только один раз):\n");

            // Создание HashSet для хранения уникальных чисел
            HashSet<int> uniqueNumbers = new HashSet<int>();

            // Ввод 10 чисел
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Число {i}: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (uniqueNumbers.Add(number))
                    {
                        Console.WriteLine($"Число {number} добавлено.");
                    }
                    else
                    {
                        Console.WriteLine($"Число {number} уже было введено ранее (пропущено).");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введено некорректное значение! Попробуйте снова.");
                    i--; // Повторяем попытку
                }
            }

            // Вывод всех уникальных чисел
            Console.WriteLine("\n=== Уникальные числа ===");
            if (uniqueNumbers.Count == 0)
            {
                Console.WriteLine("Набор пуст.");
            }
            else
            {
                Console.WriteLine($"Всего уникальных чисел: {uniqueNumbers.Count}\n");
                int index = 1;
                foreach (int number in uniqueNumbers.OrderBy(n => n))
                {
                    Console.WriteLine($"{index}. {number}");
                    index++;
                }
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

