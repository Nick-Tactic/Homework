namespace _3.Part1
{
    /// <summary>
    /// Задача 6*. Инвентарь героя
    /// Инвентарь вашего героя в RPG-игре представлен в виде массива строк (названий предметов). 
    /// Изначально он пустой. Напишите программу, которая симулирует процесс сбора предметов.
    /// </summary>
    public class Task6
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 6: Инвентарь героя ===\n");
            Console.WriteLine("Введите названия предметов для добавления в инвентарь.");
            Console.WriteLine("Введите 'стоп' для завершения сбора предметов.\n");

            // Изначально пустой инвентарь (массив строк)
            string[] inventory = new string[0];
            int itemCount = 0;

            while (true)
            {
                Console.Write("Введите название предмета: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ошибка: введена пустая строка!");
                    continue;
                }

                // Проверка команды "стоп"
                if (input.ToLower() == "стоп")
                {
                    break;
                }

                // Проверка, есть ли уже такой предмет в инвентаре
                bool alreadyExists = false;
                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i].Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (alreadyExists)
                {
                    Console.WriteLine("Это уже есть в рюкзаке!");
                }
                else
                {
                    // Увеличение размера массива и добавление нового предмета
                    string[] newInventory = new string[inventory.Length + 1];
                    for (int i = 0; i < inventory.Length; i++)
                    {
                        newInventory[i] = inventory[i];
                    }
                    newInventory[inventory.Length] = input;
                    inventory = newInventory;
                    itemCount++;
                    Console.WriteLine($"Предмет '{input}' добавлен в инвентарь!");
                }
            }

            // Вывод всего списка собранных уникальных предметов
            Console.WriteLine("\n=== ИНВЕНТАРЬ ===");
            if (inventory.Length == 0)
            {
                Console.WriteLine("Инвентарь пуст.");
            }
            else
            {
                Console.WriteLine($"Всего предметов: {inventory.Length}\n");
                for (int i = 0; i < inventory.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {inventory[i]}");
                }
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

