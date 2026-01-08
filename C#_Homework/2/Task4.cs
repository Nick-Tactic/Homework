namespace _2
{
    /// <summary>
    /// Задача 4. Сумма чисел от 1 до N
    /// Напишите программу, которая запрашивает у пользователя целое число N 
    /// и вычисляет сумму всех чисел от 1 до N с помощью цикла for.
    /// </summary>
    public class Task4
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 4: Сумма чисел от 1 до N ===\n");

            Console.Write("Введите целое число N: ");
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

            // Вычисление суммы с помощью цикла for
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"\nСумма чисел от 1 до {n} = {sum}");

            // Примечание: приятнее использовать формулу Гаусса n * (n + 1) / 2 вместо цикла

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

