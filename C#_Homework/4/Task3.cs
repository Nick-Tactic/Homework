namespace _4
{
    /// <summary>
    /// Задача 3: Инвентарь с ограничением по весу
    /// У игрока есть инвентарь, в котором можно хранить предметы. 
    /// Каждый предмет имеет вес. Общий вес не должен превышать лимит.
    /// </summary>
    public class Task3
    {
        // Структура для хранения предмета
        public class Item
        {
            public string Name { get; set; }
            public double Weight { get; set; }

            public Item(string name, double weight)
            {
                Name = name;
                Weight = weight;
            }
        }

        private static List<Item> inventory = new List<Item>();
        private const double MAX_WEIGHT = 50.0; // Максимальный вес инвентаря

        // Попытка добавить предмет в инвентарь, возвращает true если предмет добавлен, false если превышен лимит веса
        public static bool TryAddItem(string itemName, double itemWeight)
        {
            // Вычисление текущего веса инвентаря
            double currentWeight = inventory.Sum(item => item.Weight);

            // Проверка, не превысит ли добавление предмета лимит
            if (currentWeight + itemWeight > MAX_WEIGHT)
            {
                return false;
            }

            // Добавление предмета
            inventory.Add(new Item(itemName, itemWeight));
            return true;
        }

        /// Вывод всех предметов в консоль
        public static void ShowInventory()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Инвентарь пуст.");
                return;
            }

            double totalWeight = inventory.Sum(item => item.Weight);

            Console.WriteLine("=== ИНВЕНТАРЬ ===");
            Console.WriteLine($"Максимальный вес: {MAX_WEIGHT}");
            Console.WriteLine($"Текущий вес: {totalWeight:F2}");
            Console.WriteLine($"Свободно: {MAX_WEIGHT - totalWeight:F2}\n");

            Console.WriteLine("Предметы:");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {inventory[i].Name} (вес: {inventory[i].Weight:F2})");
            }
        }

        public static void Run()
        {
            Console.WriteLine("=== Задача 3: Инвентарь с ограничением по весу ===\n");
            Console.WriteLine($"Максимальный вес инвентаря: {MAX_WEIGHT}\n");

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Добавить предмет");
                Console.WriteLine("2 - Показать инвентарь");
                Console.WriteLine("0 - Выход");
                Console.Write("Ваш выбор: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите название предмета: ");
                        string? itemName = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(itemName))
                        {
                            Console.WriteLine("Ошибка: название не может быть пустым!");
                            break;
                        }

                        Console.Write("Введите вес предмета: ");
                        if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0)
                        {
                            Console.WriteLine("Ошибка: введен неверный вес!");
                            break;
                        }

                        if (TryAddItem(itemName, weight))
                        {
                            Console.WriteLine($"Предмет '{itemName}' успешно добавлен в инвентарь!");
                        }
                        else
                        {
                            double currentWeight = inventory.Sum(item => item.Weight);
                            Console.WriteLine($"Ошибка: добавление предмета превысит лимит веса!");
                            Console.WriteLine($"Текущий вес: {currentWeight:F2}, попытка добавить: {weight:F2}");
                            Console.WriteLine($"Максимальный вес: {MAX_WEIGHT}");
                        }
                        break;

                    case "2":
                        ShowInventory();
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

