namespace _2
{
    /// <summary>
    /// Задача 12*: Генератор подземелья
    /// Создайте текстовый генератор подземелья. Игрок исследует подземелье из 10 комнат. 
    /// В каждой комнате может быть: сокровище (30% шанс, +10-50 золота), 
    /// ловушка (20% шанс, -5-15 HP), монстр (30% шанс, бой), или пустая комната (20% шанс). 
    /// У игрока есть 50 HP. После каждой комнаты игрок может продолжить или выйти 
    /// с накопленным золотом. Цель - собрать как можно больше золота и выжить.
    /// </summary>
    public class Task12
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 12: Генератор подземелья ===\n");

            Random random = new Random();
            int playerHP = 50;
            int gold = 0;
            int currentRoom = 0;
            const int TOTAL_ROOMS = 10;

            Console.WriteLine("Добро пожаловать в подземелье!");
            Console.WriteLine($"У вас {playerHP} HP. Ваша цель - исследовать {TOTAL_ROOMS} комнат и собрать как можно больше золота.\n");

            // Цикл исследования комнат
            while (currentRoom < TOTAL_ROOMS && playerHP > 0)
            {
                currentRoom++;
                Console.WriteLine($"=== Комната {currentRoom}/{TOTAL_ROOMS} ===");
                Console.WriteLine($"HP: {playerHP} | Золото: {gold}\n");

                // Генерация события в комнате
                int eventChance = random.Next(1, 101);

                if (eventChance <= 30) // 30% - Сокровище
                {
                    int treasureGold = random.Next(10, 51);
                    gold += treasureGold;
                    Console.WriteLine($"Вы нашли сокровище! +{treasureGold} золота");
                }
                else if (eventChance <= 50) // 20% - Ловушка (30+20=50)
                {
                    int trapDamage = random.Next(5, 16);
                    playerHP -= trapDamage;
                    Console.WriteLine($"Ловушка! Вы получили {trapDamage} урона!");
                    if (playerHP <= 0)
                    {
                        playerHP = 0;
                        Console.WriteLine("Вы погибли от ловушки!");
                        break;
                    }
                }
                else if (eventChance <= 80) // 30% - Монстр (50+30=80)
                {
                    Console.WriteLine("В комнате монстр! Начинается бой...");

                    while (playerHP > 0)
                    {
                        // Бросок 1d20 для игрока и монстра
                        int playerRoll = random.Next(1, 21);
                        int monsterRoll = random.Next(1, 21);
                        Console.WriteLine($"\nБросок кубика: Вы - {playerRoll}, Монстр - {monsterRoll}");

                        if (playerRoll > monsterRoll)
                        {
                            // Игрок победил
                            int reward = random.Next(15, 31);
                            gold += reward;
                            Console.WriteLine($"Монстр повержен! Вы получили {reward} золота!");
                            break;
                        }
                        else if (playerRoll < monsterRoll)
                        {
                            // Игрок проиграл раунд, получает урон равный разнице
                            int damage = monsterRoll - playerRoll;
                            playerHP -= damage;
                            Console.WriteLine($"Вы проиграли раунд! Получено {damage} урона. У вас осталось {Math.Max(0, playerHP)} HP");

                            if (playerHP <= 0)
                            {
                                playerHP = 0;
                                Console.WriteLine("Вы погибли в бою с монстром!");
                                break;
                            }
                        }
                        else
                        {
                            // Ничья, бой продолжается
                            Console.WriteLine("Ничья! Бой продолжается...");
                        }
                    }
                }
                else // 20% - Пустая комната (80+20=100)
                {
                    Console.WriteLine("Комната пуста. Ничего интересного.");
                }

                // Проверка на выживание
                if (playerHP <= 0)
                {
                    break;
                }

                // Выбор: продолжить или выйти
                if (currentRoom < TOTAL_ROOMS)
                {
                    Console.WriteLine("\nЧто вы хотите сделать?");
                    Console.WriteLine("1 - Продолжить исследование");
                    Console.WriteLine("2 - Выйти из подземелья");
                    Console.Write("Ваш выбор: ");

                    if (int.TryParse(Console.ReadLine(), out int choice) && choice == 2)
                    {
                        Console.WriteLine("\nВы решили выйти из подземелья.");
                        break;
                    }
                    Console.WriteLine();
                }
            }

            // Итоговые результаты
            Console.WriteLine("\n=== ИССЛЕДОВАНИЕ ЗАВЕРШЕНО ===");
            Console.WriteLine($"Исследовано комнат: {currentRoom}/{TOTAL_ROOMS}");
            Console.WriteLine($"Оставшееся HP: {playerHP}");
            Console.WriteLine($"Собранное золото: {gold}");

            if (playerHP > 0)
            {
                Console.WriteLine("\nПоздравляю! Вы успешно выжили и вышли из подземелья!");
            }
            else
            {
                Console.WriteLine("\nВы погибли в подземелье...");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

