namespace _3.Part2
{
    /// <summary>
    /// Задача 2. Словарь переводов
    /// Создайте программу, которая использует словарь для хранения английских слов 
    /// и их переводов на русский. Позвольте пользователю запрашивать перевод слова.
    /// </summary>
    public class Task2
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 2: Словарь переводов ===\n");

            // Создание словаря для хранения переводов
            Dictionary<string, string> translations = new Dictionary<string, string>
            {
                { "hello", "привет" },
                { "world", "мир" },
                { "computer", "компьютер" },
                { "programming", "программирование" },
                { "language", "язык" },
                { "code", "код" },
                { "student", "студент" },
                { "teacher", "учитель" }
            };

            Console.WriteLine("Доступные слова в словаре:");
            foreach (var word in translations.Keys)
            {
                Console.Write($"{word}, ");
            }

            while (true)
            {
                Console.WriteLine("\n\nВведите английское слово для перевода (или 'exit' для выхода): ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ошибка: введена пустая строка!");
                    continue;
                }

                if (input.ToLower() == "exit")
                {
                    break;
                }

                // Поиск перевода в словаре
                if (translations.TryGetValue(input.ToLower(), out string? translation))
                {
                    Console.WriteLine($"Перевод: {translation}");
                }
                else
                {
                    Console.WriteLine($"Слово '{input}' не найдено в словаре.");
                    Console.Write("Хотите добавить перевод? (y/n): ");
                    string? answer = Console.ReadLine();
                    if (answer?.ToLower() == "y")
                    {
                        Console.Write("Введите русский перевод: ");
                        string? rusTranslation = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(rusTranslation))
                        {
                            translations[input.ToLower()] = rusTranslation;
                            Console.WriteLine("Перевод добавлен в словарь!");
                        }
                    }
                }
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

