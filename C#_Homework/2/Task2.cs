namespace _2
{
    /// <summary>
    /// Задача 2. Вывод максимального из трех чисел
    /// Напишите программу, которая запрашивает у пользователя три числа 
    /// и определяет, какое из них максимальное, используя условие if.
    /// </summary>
    public class Task2
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 2: Вывод максимального из трех чисел ===\n");

            // Запрос первого числа
            Console.Write("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Ошибка: введено некорректное значение!");
                Console.ReadKey();
                return;
            }

            // Запрос второго числа
            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Ошибка: введено некорректное значение!");
                Console.ReadKey();
                return;
            }

            // Запрос третьего числа
            Console.Write("Введите третье число: ");
            if (!double.TryParse(Console.ReadLine(), out double num3))
            {
                Console.WriteLine("Ошибка: введено некорректное значение!");
                Console.ReadKey();
                return;
            }

            // Поиск максимального числа
            double max = num1;

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            Console.WriteLine($"\nВведенные числа: {num1}, {num2}, {num3}");
            Console.WriteLine($"Максимальное число: {max}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

