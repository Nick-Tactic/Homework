namespace _2
{
    /// <summary>
    /// Задача 9. Таблица умножения
    /// Напишите программу, которая выводит таблицу умножения от 1 до 10 
    /// для заданного пользователем числа с помощью цикла for.
    /// </summary>
    public class Task9
        {
        public static void Run()
        {
            Console.WriteLine("=== Задача 9: Таблица умножения ===\n");

            Console.Write("Введите число для таблицы умножения: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Ошибка: введено некорректное значение!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"\nТаблица умножения для числа {number}:\n");

            // Вывод таблицы умножения с помощью цикла for
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} × {i} = {result}");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

