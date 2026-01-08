namespace _2
{
    /// <summary>
    /// Задача 3. Фруктовый выбор
    /// Напишите программу, которая запрашивает у пользователя номер фрукта (от 1 до 5) 
    /// и выводит его название с помощью оператора switch.
    /// </summary>
    public class Task3
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 3: Фруктовый выбор ===\n");
            Console.WriteLine("Выберите фрукт:");
            Console.WriteLine("1 - Яблоко");
            Console.WriteLine("2 - Банан");
            Console.WriteLine("3 - Апельсин");
            Console.WriteLine("4 - Груша");
            Console.WriteLine("5 - Виноград");
            Console.Write("\nВведите номер фрукта: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Ошибка: введено некорректное значение!");
                Console.ReadKey();
                return;
            }

            // Использование оператора switch для выбора фрукта
            string fruit;
            switch (choice)
            {
                case 1:
                    fruit = "Яблоко";
                    break;
                case 2:
                    fruit = "Банан";
                    break;
                case 3:
                    fruit = "Апельсин";
                    break;
                case 4:
                    fruit = "Груша";
                    break;
                case 5:
                    fruit = "Виноград";
                    break;
                default:
                    Console.WriteLine($"Ошибка: номер {choice} вне диапазона (1-5)!");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine($"\nВыбранный фрукт: {fruit}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

