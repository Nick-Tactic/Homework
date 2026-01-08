namespace _3.Part1
{
    /// <summary>
    /// Задача 7*. Таблица урона
    /// В игре у нас есть несколько типов оружия и врагов. Урон хранится в двумерном массиве, 
    /// где строки — это оружие, а столбцы — это враги. Нужно:
    /// - Заполнить массив значениями урона (в ручную или придумать другой способ).
    /// - Вывести таблицу в читаемом виде.
    /// - Спросить у игрока тип оружия и врага, после чего показать, сколько урона нанесено.
    /// </summary>
    public class Task7
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 7: Таблица урона ===\n");

            // Типы оружия
            string[] weapons = { "Меч", "Лук", "Посох", "Кинжал", "Топор" };

            // Типы врагов
            string[] enemies = { "Гоблин", "Орк", "Дракон", "Скелет", "Волк" };

            // Двумерный массив урона: [оружие][враг]
            int[,] damageTable = new int[,]
            {
                // Гоблин, Орк, Дракон, Скелет, Волк
                { 25, 20, 10, 30, 35 },  // Меч
                { 20, 15, 5,  25, 30 },  // Лук
                { 15, 10, 20, 20, 15 },  // Посох
                { 30, 25, 5,  35, 40 },  // Кинжал
                { 35, 30, 15, 40, 30 }   // Топор
            };

            // Вывод таблицы урона
            Console.WriteLine("=== ТАБЛИЦА УРОНА ===\n");
            Console.Write("Оружие\\Враг".PadRight(12));
            foreach (string enemy in enemies)
            {
                Console.Write(enemy.PadRight(10));
            }
            Console.WriteLine();

            for (int i = 0; i < weapons.Length; i++)
            {
                Console.Write(weapons[i].PadRight(12));
                for (int j = 0; j < enemies.Length; j++)
                {
                    Console.Write(damageTable[i, j].ToString().PadRight(10));
                }
                Console.WriteLine();
            }

            // Запрос у игрока типа оружия
            Console.WriteLine("\n=== ВЫБОР ОРУЖИЯ И ВРАГА ===\n");
            Console.WriteLine("Выберите оружие:");
            for (int i = 0; i < weapons.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {weapons[i]}");
            }
            Console.Write("\nНомер оружия: ");

            if (!int.TryParse(Console.ReadLine(), out int weaponChoice) || 
                weaponChoice < 1 || weaponChoice > weapons.Length)
            {
                Console.WriteLine("Ошибка: неверный выбор оружия!");
                Console.ReadKey();
                return;
            }

            // Запрос у игрока типа врага
            Console.WriteLine("\nВыберите врага:");
            for (int i = 0; i < enemies.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {enemies[i]}");
            }
            Console.Write("\nНомер врага: ");

            if (!int.TryParse(Console.ReadLine(), out int enemyChoice) || 
                enemyChoice < 1 || enemyChoice > enemies.Length)
            {
                Console.WriteLine("Ошибка: неверный выбор врага!");
                Console.ReadKey();
                return;
            }

            // Вычисление урона
            int damage = damageTable[weaponChoice - 1, enemyChoice - 1];

            // Вывод результата
            Console.WriteLine($"\n=== РЕЗУЛЬТАТ ===");
            Console.WriteLine($"Оружие: {weapons[weaponChoice - 1]}");
            Console.WriteLine($"Враг: {enemies[enemyChoice - 1]}");
            Console.WriteLine($"Нанесено урона: {damage}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

