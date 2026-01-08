namespace _3.Part2
{
    /// <summary>
    /// Задача 14. Очередь в таверне
    /// В таверне стоит очередь из персонажей, которые хотят получить еду или напиток. 
    /// Каждый персонаж имеет имя и заказ. Нужно обслуживать посетителей по порядку, 
    /// случайным образом определять, доволен ли персонаж обслуживанием, 
    /// и подсчитывать статистику.
    /// </summary>
    public class Task14
    {
        // Класс для представления персонажа
        public class Character
        {
            public string Name { get; set; }
            public string Order { get; set; }

            public Character(string name, string order)
            {
                Name = name;
                Order = order;
            }
        }

        public static void Run()
        {
            Console.WriteLine("=== Задача 14: Очередь в таверне ===\n");

            // Создание очереди персонажей
            Queue<Character> queue = new Queue<Character>();

            // Добавление персонажей в очередь
            queue.Enqueue(new Character("Рыцарь", "эль"));
            queue.Enqueue(new Character("Маг", "пирог"));
            queue.Enqueue(new Character("Вор", "вино"));
            queue.Enqueue(new Character("Бард", "мясо"));
            queue.Enqueue(new Character("Жрец", "хлеб"));

            Console.WriteLine("Персонажи добавлены в очередь.\n");

            Random random = new Random();
            int totalServed = 0;
            int satisfied = 0;
            int dissatisfied = 0;

            // Обслуживание посетителей
            while (queue.Count > 0)
            {
                Character customer = queue.Dequeue();
                totalServed++;

                Console.WriteLine($"=== Обслуживается: {customer.Name} ===");
                Console.WriteLine($"Заказ: {customer.Order}");

                // Случайное определение, доволен ли персонаж (70% шанс быть довольным)
                bool isSatisfied = random.Next(1, 101) <= 70;

                if (isSatisfied)
                {
                    satisfied++;
                    Console.WriteLine($"{customer.Name} доволен обслуживанием! ✓");
                }
                else
                {
                    dissatisfied++;
                    Console.WriteLine($"{customer.Name} недоволен обслуживанием... ✗");
                }

                Console.WriteLine($"\nВ очереди осталось: {queue.Count} персонажей");
                if (queue.Count > 0)
                {
                    Console.Write("Оставшиеся в очереди: ");
                    int index = 0;
                    foreach (Character c in queue)
                    {
                        Console.Write($"{c.Name}");
                        if (index < queue.Count - 1)
                        {
                            Console.Write(", ");
                        }
                        index++;
                    }
                }
                else
                {
                    Console.WriteLine("Очередь пуста.");
                }

                Console.WriteLine("\n");
            }

            // Итоговая статистика
            Console.WriteLine("=== ИТОГОВАЯ СТАТИСТИКА ===");
            Console.WriteLine($"Всего обслужено посетителей: {totalServed}");
            Console.WriteLine($"Довольных: {satisfied}");
            Console.WriteLine($"Недовольных: {dissatisfied}");
            Console.WriteLine($"Процент довольных: {(double)satisfied / totalServed * 100:F1}%");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

