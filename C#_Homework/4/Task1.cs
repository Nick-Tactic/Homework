namespace _4
{
    /// <summary>
    /// Задача 1: Генерация награды после боя
    /// После победы игрок получает случайный набор предметов. 
    /// Симулируем 5 побед игрока и 5 получений награды.
    /// </summary>
    public class Task1
    {
        // Случайно выбирает предметы из возможных, возвращает список выбранных предметов
        public static List<string> GenerateLoot(params string[] possibleLoot)
        {
            Random random = new Random();
            List<string> loot = new List<string>();

            // Случайное количество предметов (от 1 до 3)
            int itemCount = random.Next(1, 4);

            for (int i = 0; i < itemCount; i++)
            {
                // Случайный выбор предмета из возможных
                int randomIndex = random.Next(possibleLoot.Length);
                loot.Add(possibleLoot[randomIndex]);
            }

            return loot;
        }

        // Выводит список полученных предметов
        public static void ShowLoot(List<string> loot)
        {
            if (loot.Count == 0)
            {
                Console.WriteLine("  Награда не получена.");
            }
            else
            {
                Console.WriteLine($"  Получено предметов: {loot.Count}");
                for (int i = 0; i < loot.Count; i++)
                {
                    Console.WriteLine($"    {i + 1}. {loot[i]}");
                }
            }
        }

        public static void Run()
        {
            Console.WriteLine("=== Задача 1: Генерация награды после боя ===\n");

            // Возможные предметы для награды
            string[] possibleLoot = {
                "Золотая монета",
                "Магический меч",
                "Зелье здоровья",
                "Броня",
                "Щит",
                "Кольцо силы",
                "Амулет защиты",
                "Свиток заклинания"
            };

            Console.WriteLine("Симуляция 5 побед и получений награды:\n");

            // Симуляция 5 побед
            for (int victory = 1; victory <= 5; victory++)
            {
                Console.WriteLine($"=== Победа {victory} ===");

                // Генерация награды
                List<string> loot = GenerateLoot(possibleLoot);

                // Вывод награды
                ShowLoot(loot);
                Console.WriteLine();
            }

            Console.WriteLine("Нажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

