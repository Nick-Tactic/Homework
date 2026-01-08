namespace _2
{
    /// <summary>
    /// Задача 6. Числа Фибоначчи
    /// Напишите программу, которая выводит первые N чисел Фибоначчи 
    /// (N - вводится пользователем) с использованием цикла for.
    /// </summary>
    public class Task6
    {
        // Начальные значения последовательности Фибоначчи
        private const long FIBONACCI_FIRST = 0;
        private const long FIBONACCI_SECOND = 1;

        public static void Run()
        {
            Console.WriteLine("=== Задача 6: Числа Фибоначчи ===\n");

            Console.Write("Введите количество чисел Фибоначчи для вывода: ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка: введено некорректное значение!");
                Console.ReadKey();
                return;
            }

            if (n < 1)
            {
                Console.WriteLine("Ошибка: число должно быть больше 0!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"\nПервые {n} чисел Фибоначчи:");

            // Первые два числа Фибоначчи
            long first = FIBONACCI_FIRST;
            long second = FIBONACCI_SECOND;

            // Вывод первых N чисел с помощью цикла for
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.Write($"{first}");
                }
                else if (i == 1)
                {
                    Console.Write($", {second}");
                }
                else
                {
                    // Каждое следующее число = сумма двух предыдущих
                    long next = first + second;
                    Console.Write($", {next}");
                    first = second;
                    second = next;
                }
            }

            Console.WriteLine();

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

