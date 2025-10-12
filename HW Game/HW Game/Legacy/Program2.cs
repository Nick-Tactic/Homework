class Program2
{
    static void Main2()
    {
        Random rnd = new Random();
        string[] monsters = { "Гоблин", "Орк", "Дракон", "Тролль" };
        Dictionary<string, int> stats = new Dictionary<string, int>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Меню ===");
            Console.WriteLine("1 - Победить монстра");
            Console.WriteLine("2 - Показать статистику");
            Console.WriteLine("3 - Самый частый враг");
            Console.WriteLine("4 - Выход");
            Console.Write("Выберите команду: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Победить монстра
                    string monster = monsters[rnd.Next(monsters.Length)];
                    if (!stats.ContainsKey(monster))
                    {
                        stats[monster] = 0;
                    }
                    stats[monster]++;
                    Console.WriteLine($"Вы победили: {monster}!");
                    Console.WriteLine($"Побед над {monster}: {stats[monster]}");
                    break;

                case "2": // Статистика
                    if (stats.Count == 0)
                    {
                        Console.WriteLine("Статистика пуста!");
                    }
                    else
                    {
                        Console.WriteLine("\nСтатистика побед:");
                        foreach (var entry in stats)
                        {
                            Console.WriteLine($"{entry.Key}: {entry.Value}");
                        }
                    }
                    break;

                case "3": // Самый частый враг
                    if (stats.Count == 0)
                    {
                        Console.WriteLine("Статистика пуста!");
                    }
                    else
                    {
                        int maxWins = 0;
                        foreach (var entry in stats)
                        {
                            if (entry.Value > maxWins)
                                maxWins = entry.Value;
                        }

                        Console.WriteLine($"Самый(ые) частый(ые) враг(и) ({maxWins} побед):");
                        foreach (var entry in stats)
                        {
                            if (entry.Value == maxWins)
                            {
                                Console.WriteLine($"- {entry.Key}");
                            }
                        }
                    }
                    break;

                case "4": // Выход
                    running = false;
                    Console.WriteLine("Выход из программы...");
                    break;

                default:
                    Console.WriteLine("Неизвестная команда!");
                    break;
            }
        }
    }
}
