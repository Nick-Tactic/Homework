namespace _3.Part2
{
    /// <summary>
    /// Задача 6. Ведение счетов
    /// Создайте программу, используя словарь, для ведения учета счетов (например, расходов). 
    /// Каждой категории расходов присваивается сумма. 
    /// Позвольте пользователю добавлять, удалять и отображать расходы по категориям.
    /// </summary>
    public class Task6
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 6: Ведение счетов ===\n");

            // Создание словаря для учета расходов по категориям
            Dictionary<string, double> expenses = new Dictionary<string, double>();

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Добавить расход");
                Console.WriteLine("2 - Удалить категорию");
                Console.WriteLine("3 - Показать все расходы");
                Console.WriteLine("4 - Показать общую сумму");
                Console.WriteLine("0 - Выход");
                Console.Write("Ваш выбор: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите категорию расхода: ");
                        string? category = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(category))
                        {
                            Console.WriteLine("Ошибка: категория не может быть пустой!");
                            break;
                        }

                        Console.Write("Введите сумму: ");
                        if (double.TryParse(Console.ReadLine(), out double amount))
                        {
                            if (expenses.ContainsKey(category))
                            {
                                expenses[category] += amount;
                                Console.WriteLine($"Сумма в категории '{category}' обновлена: {expenses[category]:F2}");
                            }
                            else
                            {
                                expenses[category] = amount;
                                Console.WriteLine($"Категория '{category}' добавлена с суммой {amount:F2}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: введена неверная сумма!");
                        }
                        break;

                    case "2":
                        if (expenses.Count == 0)
                        {
                            Console.WriteLine("Список расходов пуст!");
                            break;
                        }

                        Console.WriteLine("\nКатегории расходов:");
                        int index = 1;
                        foreach (var cat in expenses.Keys)
                        {
                            Console.WriteLine($"{index}. {cat}");
                            index++;
                        }

                        Console.Write("\nВведите название категории для удаления: ");
                        string? catToRemove = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(catToRemove) && expenses.Remove(catToRemove))
                        {
                            Console.WriteLine($"Категория '{catToRemove}' удалена.");
                        }
                        else
                        {
                            Console.WriteLine($"Категория '{catToRemove}' не найдена!");
                        }
                        break;

                    case "3":
                        if (expenses.Count == 0)
                        {
                            Console.WriteLine("Список расходов пуст!");
                        }
                        else
                        {
                            Console.WriteLine("\n=== РАСХОДЫ ПО КАТЕГОРИЯМ ===");
                            foreach (var expense in expenses)
                            {
                                Console.WriteLine($"{expense.Key}: {expense.Value:F2}");
                            }
                        }
                        break;

                    case "4":
                        double total = expenses.Values.Sum();
                        Console.WriteLine($"\nОбщая сумма расходов: {total:F2}");
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

