namespace _1
{
    /// <summary>
    /// Задача 1: Объявление переменных
    /// Создайте программу, в которой объявите переменные разных типов данных 
    /// (int, double, char, string, bool). Присвойте им значения и выведите их на экран.
    /// </summary>
    public class Task1
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 1: Объявление переменных ===\n");

            // Объявление и инициализация переменных разных типов
            int integerNumber = 42;                    // Целое число
            double doubleNumber = 3.14159;             // Число с плавающей точкой
            char character = 'A';                      // Символ
            string text = "Hello, World!";              // Строка
            bool booleanValue = true;                  // Логическое значение

            // Вывод значений на экран
            Console.WriteLine($"Целое число (int): {integerNumber}");
            Console.WriteLine($"Число с плавающей точкой (double): {doubleNumber}");
            Console.WriteLine($"Символ (char): {character}");
            Console.WriteLine($"Строка (string): {text}");
            Console.WriteLine($"Логическое значение (bool): {booleanValue}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

