namespace _2
{
    /// <summary>
    /// Задача 10. Числовая угадайка
    /// Напишите игру, в которой программа случайным образом выбирает число от 1 до 100, 
    /// а пользователь пытается его угадать. Программа должна сообщать, выше или ниже загаданное число, 
    /// используя цикл while. Игра продолжается, пока число не будет угадано.
    /// </summary>
    public class Task10
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 10: Числовая угадайка ===\n");

            // Генерация случайного числа от 1 до 100
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int attempts = 0;
            int guess = 0;

            Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать!\n");

            // Цикл угадывания с помощью while
            while (guess != secretNumber)
            {
                attempts++;
                Console.Write($"Попытка {attempts}. Введите ваше число: ");

                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Ошибка: введено некорректное значение! Попробуйте снова.\n");
                    attempts--; // Не засчитываем неверный ввод
                    continue;
                }

                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Число должно быть от 1 до 100! Попробуйте снова.\n");
                    continue;
                }

                // Проверка результата
                if (guess < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше!\n");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Загаданное число меньше!\n");
                }
                else
                {
                    Console.WriteLine($"\nПоздравляю! Вы угадали число {secretNumber} за {attempts} попыток!");
                }
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

