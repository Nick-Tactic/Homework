namespace _2
{
    /// <summary>
    /// Задача 7. Проверка палиндрома
    /// Напишите программу, которая запрашивает у пользователя строку 
    /// и проверяет, является ли она палиндромом (читается одинаково слева направо и справа налево). 
    /// Для проверки используйте условие if и цикл foreach.
    /// </summary>
    public class Task7
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 7: Проверка палиндрома ===\n");

            Console.Write("Введите строку для проверки: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ошибка: введена пустая строка!");
                Console.ReadKey();
                return;
            }

            // Построение обратной строки с помощью цикла foreach
            string reversed = "";
            foreach (char c in input)
            {
                reversed = c + reversed; // Добавляем символ в начало строки
            }

            // Проверка, является ли строка палиндромом
            if (input == reversed)
            {
                Console.WriteLine($"\nСтрока '{input}' является палиндромом!");
            }
            else
            {
                Console.WriteLine($"\nСтрока '{input}' НЕ является палиндромом.");
                Console.WriteLine($"Оригинал: {input}");
                Console.WriteLine($"Обратная: {reversed}");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

