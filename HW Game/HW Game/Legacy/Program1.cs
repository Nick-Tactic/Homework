class Item
{
    public string Name { get; set; }
    public int Weight { get; set; }

    public Item(string name, int weight)
    {
        Name = name;
        Weight = weight;
    }

    public override string ToString()
    {
        return $"{Name} (вес: {Weight})";
    }
}

class Inventory
{
    private List<Item> items = new List<Item>();
    private int weightLimit;
    private int currentWeight = 0;

    public Inventory(int limit)
    {
        weightLimit = limit;
    }

    public void AddItem(Item item)
    {
        if (currentWeight + item.Weight > weightLimit)
        {
            Console.WriteLine($"Нельзя добавить \"{item.Name}\" — лимит веса превышен!");
        }
        else
        {
            items.Add(item);
            currentWeight += item.Weight;
            Console.WriteLine($"Предмет \"{item.Name}\" добавлен! (Текущий вес: {currentWeight}/{weightLimit})");
        }
    }

    public void RemoveItem(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            Console.WriteLine("Неверный индекс!");
        }
        else
        {
            Item removed = items[index];
            items.RemoveAt(index);
            currentWeight -= removed.Weight;
            Console.WriteLine($"Предмет \"{removed.Name}\" удалён. (Текущий вес: {currentWeight}/{weightLimit})");
        }
    }

    public void ShowItems()
    {
        Console.WriteLine("\nСодержимое инвентаря:");
        if (items.Count == 0)
        {
            Console.WriteLine("[Инвентарь пуст]");
        }
        else
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i}: {items[i]}");
            }
        }
        Console.WriteLine($"Общий вес: {currentWeight}/{weightLimit}");
    }
}

class Program
{
    static void Main1()
    {
        Inventory inventory = new Inventory(15); // лимит веса — 15
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Инвентарь ===");
            Console.WriteLine("1 - Добавить предмет");
            Console.WriteLine("2 - Удалить предмет");
            Console.WriteLine("3 - Показать содержимое");
            Console.WriteLine("4 - Выход");
            Console.Write("Выберите команду: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите название предмета: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите вес предмета: ");
                    if (int.TryParse(Console.ReadLine(), out int weight))
                    {
                        inventory.AddItem(new Item(name, weight));
                    }
                    else
                    {
                        Console.WriteLine("Некорректный вес!");
                    }
                    break;

                case "2":
                    Console.Write("Введите индекс предмета: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        inventory.RemoveItem(index);
                    }
                    else
                    {
                        Console.WriteLine("Введите число!");
                    }
                    break;

                case "3":
                    inventory.ShowItems();
                    break;

                case "4":
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