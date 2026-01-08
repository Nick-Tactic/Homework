namespace _3.Part2
{
    /// <summary>
    /// Задача 13. Реализовать имитацию сражения игрока с монстрами и вести статистику побед
    /// Программа должна предоставлять меню с командами:
    /// - Победить монстра (случайный выбор, увеличение счетчика)
    /// - Показать статистику
    /// - Самый частый враг
    /// </summary>
    public class Task13
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 13: Имитация сражения игрока с монстрами ===\n");

            // Список монстров
            List<string> monsters = new List<string> { "Гоблин", "Орк", "Дракон", "Тролль" };

            // Словарь для ведения статистики побед
            Dictionary<string, int> victoryStats = new Dictionary<string, int>();

            Random random = new Random();

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Победить монстра");
                Console.WriteLine("2 - Показать статистику");
                Console.WriteLine("3 - Самый частый враг");
                Console.WriteLine("0 - Выход");
                Console.Write("Ваш выбор: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Случайный выбор монстра
                        string monster = monsters[random.Next(monsters.Count)];

                        // Увеличение счетчика для выбранного монстра
                        if (victoryStats.ContainsKey(monster))
                        {
                            victoryStats[monster]++;
                        }
                        else
                        {
                            victoryStats[monster] = 1;
                        }

                        Console.WriteLine($"\nВы победили {monster}!");
                        Console.WriteLine($"Всего побед над {monster}: {victoryStats[monster]}");
                        break;

                    case "2":
                        if (victoryStats.Count == 0)
                        {
                            Console.WriteLine("\nСтатистика пуста!");
                        }
                        else
                        {
                            Console.WriteLine("\n=== СТАТИСТИКА ПОБЕД ===");
                            // Сортировка по частоте (количеству убийств) по убыванию
                            var sortedStats = victoryStats.OrderByDescending(m => m.Value);
                            int totalVictories = 0;
                            foreach (var stat in sortedStats)
                            {
                                Console.WriteLine($"{stat.Key}: {stat.Value} побед(ы)");
                                totalVictories += stat.Value;
                            }
                            Console.WriteLine($"\nВсего побед: {totalVictories}");
                        }
                        break;

                    case "3":
                        if (victoryStats.Count == 0)
                        {
                            Console.WriteLine("\nСтатистика пуста!");
                        }
                        else
                        {
                            // Поиск монстра с максимальным количеством побед
                            var mostFrequent = victoryStats.OrderByDescending(m => m.Value).First();
                            Console.WriteLine($"\nСамый частый враг: {mostFrequent.Key}");
                            Console.WriteLine($"Количество побед над ним: {mostFrequent.Value}");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Выход из программы.");
                        Console.ReadKey();
                        return;

                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }
    }
}

