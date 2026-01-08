namespace _1
{
    /// <summary>
    /// Задача 6: Преобразование типов данных
    /// Создайте программу, которая запрашивает у пользователя число в виде строки. 
    /// Преобразуйте его в тип int и выведите его квадрат на экран.
    /// </summary>
    public class Task6
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 6: Преобразование типов данных ===\n");

            // Запрос числа в виде строки
            Console.Write("Введите число (в виде строки): ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ошибка: введена пустая строка!");
                Console.ReadKey();
                return;
            }

            // Преобразование строки в int
            // Дополнительная информация о преобразовании:
            // Метод int.TryParse() безопасно преобразует строку в число.
            // Если преобразование невозможно, метод возвращает false.
            // Если преобразование успешно, число сохраняется в переменную через параметр out.
            if (int.TryParse(input, out int number))
            {
                // Вычисление квадрата числа
                int square = number * number;
                Console.WriteLine($"\nВведенное число: {number}");
                Console.WriteLine($"Квадрат числа {number} = {number}² = {square}");
            }
            else
            {
                Console.WriteLine($"Ошибка: '{input}' не является целым числом!");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

