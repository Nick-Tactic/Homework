namespace _1
{
    /// <summary>
    /// Задача 4: Операторы сравнения
    /// Напишите программу, которая принимает на вход два числа и сравнивает их. 
    /// Используйте операторы сравнения и выведите, какое число больше, меньше или равны ли они.
    /// </summary>
    public class Task4
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 4: Операторы сравнения ===\n");

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

            Console.WriteLine($"\nСравнение чисел: {num1} и {num2}\n");

            // Операторы сравнения
            bool isEqual = num1 == num2;           // Равно
            bool isNotEqual = num1 != num2;        // Не равно
            bool isGreater = num1 > num2;          // Больше
            bool isLess = num1 < num2;             // Меньше
            bool isGreaterOrEqual = num1 >= num2;  // Больше или равно
            bool isLessOrEqual = num1 <= num2;     // Меньше или равно

            // Вывод результатов
            Console.WriteLine($"{num1} == {num2} : {isEqual}");
            Console.WriteLine($"{num1} != {num2} : {isNotEqual}");
            Console.WriteLine($"{num1} > {num2}  : {isGreater}");
            Console.WriteLine($"{num1} < {num2}  : {isLess}");
            Console.WriteLine($"{num1} >= {num2} : {isGreaterOrEqual}");
            Console.WriteLine($"{num1} <= {num2} : {isLessOrEqual}");

            // Вывод текстового результата
            Console.WriteLine("\n=== Результат сравнения ===");
            if (isEqual)
            {
                Console.WriteLine($"Числа {num1} и {num2} равны.");
            }
            else if (isGreater)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}.");
            }
            else
            {
                Console.WriteLine($"Число {num1} меньше числа {num2}.");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

