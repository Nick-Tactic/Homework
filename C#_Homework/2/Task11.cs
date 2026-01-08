namespace _2
{
    /// <summary>
    /// Задача 11*: Симулятор боя с боссом
    /// Создайте пошаговый симулятор боя между игроком и боссом. 
    /// У игрока есть 100 HP и 3 типа атак: обычная (15-25 урона), 
    /// сильная (30-40 урона, можно использовать раз в 3 хода) и лечение 
    /// (восстанавливает 20-30 HP, можно использовать 3 раза за бой). 
    /// Босс имеет 150 HP и атакует случайным уроном от 10 до 30. 
    /// Бой идет по ходам до победы одной из сторон.
    /// </summary>
    public class Task11
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 11: Симулятор боя с боссом ===\n");

            Random random = new Random();

            // Инициализация характеристик
            const int MAX_PLAYER_HP = 100;
            int playerHP = MAX_PLAYER_HP;
            int bossHP = 150;
            int turnsSinceStrongAttack = 0; // Счетчик ходов с последней сильной атаки
            int healUses = 0; // Количество использований лечения
            const int MAX_HEAL_USES = 3;
            int turn = 1;

            Console.WriteLine("=== БОЙ НАЧАЛСЯ ===\n");
            Console.WriteLine($"Игрок: {playerHP} HP");
            Console.WriteLine($"Босс: {bossHP} HP\n");

            // Основной цикл боя
            while (playerHP > 0 && bossHP > 0)
            {
                Console.WriteLine($"--- Ход {turn} ---\n");

                // Ход игрока
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Обычная атака (15-25 урона)");
                Console.WriteLine("2 - Сильная атака (30-40 урона, можно раз в 3 хода)");
                Console.WriteLine("3 - Лечение (20-30 HP, можно использовать 3 раза)");
                Console.Write("Ваш выбор: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Некорректный ввод! Используется обычная атака.\n");
                    choice = 1;
                }

                // Обработка выбора игрока
                // Примечание: обычную атаку следовало бы оформить как отдельный метод и вызывать его,
                // но это делать лень и копировать код проще
                switch (choice)
                {
                    case 1: // Обычная атака
                        int normalDamage = random.Next(15, 26);
                        bossHP -= normalDamage;
                        Console.WriteLine($"Вы нанесли {normalDamage} урона боссу!");
                        break;

                    case 2: // Сильная атака
                        if (turnsSinceStrongAttack >= 3)
                        {
                            int strongDamage = random.Next(30, 41);
                            bossHP -= strongDamage;
                            turnsSinceStrongAttack = 0;
                            Console.WriteLine($"Вы нанесли {strongDamage} урона сильной атакой!");
                        }
                        else
                        {
                            Console.WriteLine("Сильная атака еще не готова! Используется обычная атака.");
                            int normalDamage2 = random.Next(15, 26);
                            bossHP -= normalDamage2;
                            Console.WriteLine($"Вы нанесли {normalDamage2} урона боссу!");
                        }
                        break;

                    case 3: // Лечение
                        if (healUses < MAX_HEAL_USES)
                        {
                            int healAmount = random.Next(20, 31);
                            int oldHP = playerHP;
                            playerHP += healAmount;
                            // Ограничение максимальным здоровьем
                            if (playerHP > MAX_PLAYER_HP)
                            {
                                playerHP = MAX_PLAYER_HP;
                            }
                            int actualHeal = playerHP - oldHP;
                            healUses++;
                            Console.WriteLine($"Вы восстановили {actualHeal} HP! (Использовано: {healUses}/{MAX_HEAL_USES})");
                        }
                        else
                        {
                            Console.WriteLine("Лечение закончилось! Используется обычная атака.");
                            int normalDamage3 = random.Next(15, 26);
                            bossHP -= normalDamage3;
                            Console.WriteLine($"Вы нанесли {normalDamage3} урона боссу!");
                        }
                        break;

                    default:
                        Console.WriteLine("Некорректный ввод! Используется обычная атака.");
                        int normalDamage4 = random.Next(15, 26);
                        bossHP -= normalDamage4;
                        Console.WriteLine($"Вы нанесли {normalDamage4} урона боссу!");
                        break;
                }

                // Проверка на победу игрока
                if (bossHP <= 0)
                {
                    bossHP = 0;
                    Console.WriteLine($"\nБосс повержен! У босса осталось {bossHP} HP");
                    break;
                }

                // Ход босса
                int bossDamage = random.Next(10, 31);
                playerHP -= bossDamage;
                Console.WriteLine($"Босс атакует и наносит {bossDamage} урона!");

                // Проверка на поражение игрока
                if (playerHP <= 0)
                {
                    playerHP = 0;
                    Console.WriteLine($"\nВы проиграли! У вас осталось {playerHP} HP");
                    break;
                }

                // Обновление состояния
                turnsSinceStrongAttack++;
                Console.WriteLine($"\nИгрок: {playerHP} HP | Босс: {bossHP} HP\n");
                turn++;
            }

            // Итоговый результат
            Console.WriteLine("\n=== БОЙ ЗАВЕРШЕН ===");
            if (playerHP > 0)
            {
                Console.WriteLine("ПОБЕДА! Вы победили босса!");
            }
            else
            {
                Console.WriteLine("ПОРАЖЕНИЕ! Босс победил вас.");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

