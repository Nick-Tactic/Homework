namespace _2
{
    /// <summary>
    /// Задача 1. Определение четного или нечетного числа
    /// Напишите программу, которая запрашивает у пользователя целое число 
    /// и выводит, является ли оно четным или нечетным. Используйте условие if.
    /// </summary>
    public class Task1
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 1: Определение четного или нечетного числа ===\n");

            Console.Write("Введите целое число: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Ошибка: введено некорректное значение!");
                Console.ReadKey();
                return;
            }

            // Проверка на четность: число четное, если остаток от деления на 2 равен 0
            if (number % 2 == 0)
            {
                Console.WriteLine($"Число {number} является четным.");
            }
            else
            {
                Console.WriteLine($"Число {number} является нечетным.");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

