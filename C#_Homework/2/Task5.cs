namespace _2
{
    /// <summary>
    /// Задача 5. Факториал числа
    /// Напишите программу для вычисления факториала числа N (N!) 
    /// с использованием цикла while. Сделайте так, чтобы программа запрашивала N 
    /// и продолжала запрашивать, пока пользователь не введет отрицательное число.
    /// </summary>
    public class Task5
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 5: Факториал числа ===\n");
            Console.WriteLine("Введите отрицательное число для выхода.\n");

            while (true)
            {
                Console.Write("Введите число N для вычисления факториала: ");
                if (!int.TryParse(Console.ReadLine(), out int n))
                {
                    Console.WriteLine("Ошибка: введено некорректное значение!");
                    continue;
                }

                // Проверка на отрицательное число (выход из цикла)
                if (n < 0)
                {
                    Console.WriteLine("Введено отрицательное число. Выход из программы.");
                    break;
                }

                // Вычисление факториала с помощью цикла while
                long factorial = 1;
                int i = 1;

                while (i <= n)
                {
                    factorial *= i;
                    i++;
                }

                Console.WriteLine($"Факториал {n}! = {factorial}\n");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

