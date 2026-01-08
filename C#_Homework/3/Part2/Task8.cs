namespace _3.Part2
{
    /// <summary>
    /// Задача 8. Словарь частоты слов
    /// Напишите программу, которая принимает текст и подсчитывает частоту каждого слова, 
    /// используя словарь.
    /// </summary>
    public class Task8
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 8: Словарь частоты слов ===\n");

            Console.WriteLine("Введите текст для анализа:");
            string? text = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Ошибка: введен пустой текст!");
                Console.ReadKey();
                return;
            }

            // Разделение текста на слова (удаление знаков препинания и приведение к нижнему регистру)
            char[] separators = { ' ', '.', ',', '!', '?', ';', ':', '-', '\n', '\r', '\t' };
            string[] words = text.ToLower()
                                 .Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Создание словаря для подсчета частоты слов
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            // Подсчет частоты каждого слова
            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }

            // Вывод результатов
            Console.WriteLine($"\n=== ЧАСТОТА СЛОВ ===");
            Console.WriteLine($"Всего слов в тексте: {words.Length}");
            Console.WriteLine($"Уникальных слов: {wordFrequency.Count}\n");

            // Сортировка по частоте (по убыванию)
            var sortedWords = wordFrequency.OrderByDescending(w => w.Value);

            Console.WriteLine("Слова и их частота:");
            foreach (var word in sortedWords)
            {
                Console.WriteLine($"  '{word.Key}': {word.Value} раз(а)");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

