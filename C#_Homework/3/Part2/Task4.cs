namespace _3.Part2
{
    /// <summary>
    /// Задача 4. Очередь для обслуживания клиентов
    /// Создайте программу, которая использует очередь для регистрации клиентов в магазине. 
    /// Каждый шаг цикла клиент удаляется из очереди. 
    /// Необходимо вывести обновленную очередь в консоль.
    /// </summary>
    public class Task4
        {
        public static void Run()
        {
            Console.WriteLine("=== Задача 4: Очередь для обслуживания клиентов ===\n");

            // Создание очереди для клиентов
            Queue<string> customers = new Queue<string>();

            // Добавление клиентов в очередь
            Console.WriteLine("Добавление клиентов в очередь...");
            customers.Enqueue("Иван");
            customers.Enqueue("Мария");
            customers.Enqueue("Петр");
            customers.Enqueue("Анна");
            customers.Enqueue("Сергей");

            Console.WriteLine($"В очереди {customers.Count} клиентов.\n");

            // Обслуживание клиентов
            int step = 1;
            while (customers.Count > 0)
            {
                // Обслуживание клиента (удаление из очереди)
                string currentCustomer = customers.Dequeue();
                Console.WriteLine($"Шаг {step}: Обслуживается клиент '{currentCustomer}'");

                // Вывод обновленной очереди
                if (customers.Count > 0)
                {
                    Console.Write("Оставшиеся в очереди: ");
                    int index = 0;
                    foreach (string customer in customers)
                    {
                        Console.Write(customer);
                        if (index < customers.Count - 1)
                        {
                            Console.Write(", ");
                        }
                        index++;
                    }
                    Console.WriteLine($" ({customers.Count} клиентов)");
                }
                else
                {
                    Console.WriteLine("Очередь пуста. Все клиенты обслужены.");
                }

                Console.WriteLine();
                step++;
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

