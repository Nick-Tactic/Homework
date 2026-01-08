namespace _2
{
    /// <summary>
    /// Задача 8. Поиск максимального числа
    /// Напишите программу, которая принимает 5 чисел от пользователя 
    /// и находит максимальное, используя цикл while.
    /// </summary>
    public class Task8
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 8: Поиск максимального числа ===\n");

            double max = double.MinValue; // Начальное значение - минимальное возможное
            int count = 0;
            const int totalNumbers = 5;

            Console.WriteLine($"Введите {totalNumbers} чисел:");

            // Ввод чисел с помощью цикла while
            while (count < totalNumbers)
            {
                Console.Write($"Число {count + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    // Обновление максимального значения
                    if (number > max)
                    {
                        max = number;
                    }
                    count++;
                }
                else
                {
                    Console.WriteLine("Ошибка: введено некорректное значение! Попробуйте снова.");
                }
            }

            Console.WriteLine($"\nМаксимальное число: {max}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

