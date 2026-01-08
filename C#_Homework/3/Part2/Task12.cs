namespace _3.Part2
{
    /// <summary>
    /// Задача 12. Базовый инвентарь
    /// У игрока есть инвентарь на 5 слотов. Реализуйте:
    /// - Добавление предмета (если инвентарь заполнен — выводится сообщение).
    /// - Удаление предмета по индексу.
    /// - Вывод содержимого инвентаря.
    /// - Выбор команд от юзера осуществляется в цикле (1 - добавить и т.д.)
    /// </summary>
    public class Task12
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 12: Базовый инвентарь ===\n");

            // Создание инвентаря на 5 слотов (используем список для удобства)
            List<string> inventory = new List<string>();
            const int MAX_SLOTS = 5;

            while (true)
            {
                Console.WriteLine("\n=== ИНВЕНТАРЬ ===");
                Console.WriteLine($"Слотов занято: {inventory.Count}/{MAX_SLOTS}");
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Добавить предмет");
                Console.WriteLine("2 - Удалить предмет по индексу");
                Console.WriteLine("3 - Показать содержимое инвентаря");
                Console.WriteLine("0 - Выход");
                Console.Write("Ваш выбор: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (inventory.Count >= MAX_SLOTS)
                        {
                            Console.WriteLine("Инвентарь заполнен! Нельзя добавить больше предметов.");
                        }
                        else
                        {
                            Console.Write("Введите название предмета: ");
                            string? item = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(item))
                            {
                                inventory.Add(item);
                                Console.WriteLine($"Предмет '{item}' добавлен в инвентарь.");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: название предмета не может быть пустым!");
                            }
                        }
                        break;

                    case "2":
                        if (inventory.Count == 0)
                        {
                            Console.WriteLine("Инвентарь пуст!");
                        }
                        else
                        {
                            ShowInventory(inventory);
                            Console.Write("\nВведите индекс предмета для удаления (начиная с 1): ");
                            if (int.TryParse(Console.ReadLine(), out int index) && 
                                index >= 1 && index <= inventory.Count)
                            {
                                string removed = inventory[index - 1];
                                inventory.RemoveAt(index - 1);
                                Console.WriteLine($"Предмет '{removed}' удален из инвентаря.");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: неверный индекс!");
                            }
                        }
                        break;

                    case "3":
                        ShowInventory(inventory);
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

        /// Вспомогательный метод для отображения инвентаря
        private static void ShowInventory(List<string> inventory)
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Инвентарь пуст.");
            }
            else
            {
                Console.WriteLine("\nСодержимое инвентаря:");
                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.WriteLine($"  {i + 1}. {inventory[i]}");
                }
            }
        }
    }
}

