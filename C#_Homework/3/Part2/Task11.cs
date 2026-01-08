namespace _3.Part2
{
    /// <summary>
    /// Задача 11. Подсчет чисел, превышающих заданное значение
    /// Напишите программу, которая создает список целых чисел и считает, 
    /// сколько чисел в этом списке превышают заданное значение, введенное пользователем.
    /// </summary>
    public class Task11
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 11: Подсчет чисел, превышающих заданное значение ===\n");

            // Создание списка целых чисел
            List<int> numbers = new List<int> { 15, 23, 8, 45, 12, 67, 34, 89, 56, 23, 78, 45, 12, 90, 34 };

            Console.WriteLine("Список чисел:");
            PrintList(numbers);

            // Запрос порогового значения у пользователя
            Console.Write("\nВведите пороговое значение: ");
            if (!int.TryParse(Console.ReadLine(), out int threshold))
            {
                Console.WriteLine("Ошибка: введено некорректное значение!");
                Console.ReadKey();
                return;
            }

            // Подсчет чисел, превышающих заданное значение
            int count = 0;
            List<int> exceedingNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number > threshold)
                {
                    count++;
                    exceedingNumbers.Add(number);
                }
            }

            // Вывод результатов
            Console.WriteLine($"\nПороговое значение: {threshold}");
            Console.WriteLine($"Чисел, превышающих {threshold}: {count}");

            if (exceedingNumbers.Count > 0)
            {
                Console.WriteLine("\nЧисла, превышающие пороговое значение:");
                PrintList(exceedingNumbers);
            }
            else
            {
                Console.WriteLine("Нет чисел, превышающих пороговое значение.");
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

