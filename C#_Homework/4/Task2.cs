namespace _4
{
    /// <summary>
    /// Задача 2: Прокачка персонажа
    /// Игрок может повышать характеристики. Реализуйте методы LevelUp с перегрузкой.
    /// </summary>
    public class Task2
    {
        // Увеличивает здоровье и атаку персонажа (параметры передаются по ссылке)
        public static void LevelUp(ref int health, ref int attack)
        {
            health += 10;
            attack += 5;
            Console.WriteLine($"  Здоровье увеличено на 10, атака увеличена на 5");
        }

        // Перегруженный метод: увеличивает характеристики с бонусом (параметры health и attack передаются по ссылке)
        public static void LevelUp(ref int health, ref int attack, int bonus)
        {
            health += 10 + bonus;
            attack += 5 + bonus;
            Console.WriteLine($"  Здоровье увеличено на {10 + bonus}, атака увеличена на {5 + bonus} (бонус: {bonus})");
        }

        public static void Run()
        {
            Console.WriteLine("=== Задача 2: Прокачка персонажа ===\n");

            // Начальные характеристики персонажа
            int health = 100;
            int attack = 20;

            Console.WriteLine("Начальные характеристики:");
            Console.WriteLine($"  Здоровье: {health}");
            Console.WriteLine($"  Атака: {attack}\n");

            // Использование базового метода LevelUp
            Console.WriteLine("=== Уровень 2 (базовый LevelUp) ===");
            LevelUp(ref health, ref attack);
            Console.WriteLine($"  Текущее здоровье: {health}");
            Console.WriteLine($"  Текущая атака: {attack}\n");

            // Использование перегруженного метода LevelUp с бонусом
            Console.WriteLine("=== Уровень 3 (LevelUp с бонусом +5) ===");
            LevelUp(ref health, ref attack, 5);
            Console.WriteLine($"  Текущее здоровье: {health}");
            Console.WriteLine($"  Текущая атака: {attack}\n");

            // Еще один уровень с большим бонусом
            Console.WriteLine("=== Уровень 4 (LevelUp с бонусом +10) ===");
            LevelUp(ref health, ref attack, 10);
            Console.WriteLine($"  Текущее здоровье: {health}");
            Console.WriteLine($"  Текущая атака: {attack}\n");

            Console.WriteLine("Итоговые характеристики:");
            Console.WriteLine($"  Здоровье: {health}");
            Console.WriteLine($"  Атака: {attack}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

