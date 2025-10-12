class Program3
{
    class Visitor
    {
        public string Name { get; set; }
        public string Order { get; set; }
        public string Gender { get; set; } // "м" или "ж"

        public Visitor(string name, string order, string gender)
        {
            Name = name;
            Order = order;
            Gender = gender;
        }
    }

    static void Main3()
    {
        Queue<Visitor> tavernQueue = new Queue<Visitor>();
        Random rnd = new Random();

        // Добавляем персонажей в очередь (имя, заказ, пол)
        tavernQueue.Enqueue(new Visitor("Артур", "Эль", "м"));
        tavernQueue.Enqueue(new Visitor("Моргана", "Вино", "ж"));
        tavernQueue.Enqueue(new Visitor("Ланселот", "Мясо на кости", "м"));
        tavernQueue.Enqueue(new Visitor("Гвен", "Пиво", "ж"));
        tavernQueue.Enqueue(new Visitor("Мерлин", "Медовуха", "м"));
        tavernQueue.Enqueue(new Visitor("Мэттью", "Овощи гриль", "м"));
        tavernQueue.Enqueue(new Visitor("Винсент", "Вино", "м"));
        tavernQueue.Enqueue(new Visitor("Крогнар", "Мясо (просто мясо)", "м"));
        tavernQueue.Enqueue(new Visitor("Констанс", "Медовуха", "ж"));
        tavernQueue.Enqueue(new Visitor("Костян", "Ребра свиные (можно без мяса)", "м"));
        tavernQueue.Enqueue(new Visitor("Алехандро де Селагора", "Кровь девственницы", "м"));
        tavernQueue.Enqueue(new Visitor("Вергилий", "Motivation!", "м"));
        tavernQueue.Enqueue(new Visitor("Снова Вергилий", "Power!", "м"));
        tavernQueue.Enqueue(new Visitor("Какая-то проститутка", "Салатик за 300 золотых", "ж"));
        tavernQueue.Enqueue(new Visitor("Брюс", "Эта таверна", "м"));

        int total = 0;
        int happy = 0;
        int unhappy = 0;

        Console.WriteLine("Обслуживание началось!\n");

        while (tavernQueue.Count > 0)
        {
            Visitor visitor = tavernQueue.Dequeue();
            Console.WriteLine($"Посетитель {visitor.Name} заказал: {visitor.Order}");

            bool isHappy = rnd.Next(2) == 0; // 50% шанс

            if (visitor.Gender == "ж")
            {
                if (isHappy)
                {
                    Console.WriteLine($"{visitor.Name} довольна обслуживанием!");
                    happy++;
                }
                else
                {
                    Console.WriteLine($"{visitor.Name} недовольна...");
                    unhappy++;
                }
            }
            else // мужской пол
            {
                if (isHappy)
                {
                    Console.WriteLine($"{visitor.Name} доволен обслуживанием!");
                    happy++;
                }
                else
                {
                    Console.WriteLine($"{visitor.Name} недоволен...");
                    unhappy++;
                }
            }

            total++;
            Console.WriteLine();

            Thread.Sleep(1000); // задержка 1 секунду перед следующим посетителем
        }

        Console.WriteLine("=== Итоговая статистика ===");
        Console.WriteLine($"Всего обслужено: {total}");
        Console.WriteLine($"Довольных: {happy}");
        Console.WriteLine($"Недовольных: {unhappy}");
    }
}
