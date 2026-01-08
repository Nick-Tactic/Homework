namespace _1
{
    /// <summary>
    /// Задача 3: Арифметические операторы
    /// Напишите программу, которая запрашивает у пользователя два числа, 
    /// выполняет над ними все возможные арифметические операции 
    /// (сложение, вычитание, умножение, деление) и выводит результаты на экран.
    /// </summary>
    public class Task3
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 3: Арифметические операторы ===\n");

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

            Console.WriteLine("\n=== Результаты арифметических операций ===");

            // Сложение
            double sum = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {sum}");

            // Вычитание
            double difference = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {difference}");

            // Умножение
            double product = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {product}");

            // Деление
            if (num2 != 0)
            {
                double quotient = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {quotient}");
            }
            else
            {
                Console.WriteLine($"{num1} / {num2} = Ошибка: деление на ноль!");
            }

            // Целочисленное деление
            if (num2 != 0)
            {
                int integerQuotient = (int)(num1 / num2);
                Console.WriteLine($"{num1} // {num2} = {integerQuotient} (целочисленное деление)");
            }
            else
            {
                Console.WriteLine($"{num1} // {num2} = Ошибка: деление на ноль!");
            }

            // Остаток от деления
            if (num2 != 0)
            {
                double remainder = num1 % num2;
                Console.WriteLine($"{num1} % {num2} = {remainder}");
            }
            else
            {
                Console.WriteLine($"{num1} % {num2} = Ошибка: деление на ноль!");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

