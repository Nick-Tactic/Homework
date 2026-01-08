namespace _1
{
    /// <summary>
    /// Задача 8: Операции с константами
    /// Создайте программу, в которой вы используете определенные константы 
    /// для расчета площади круга и площади квадрата. 
    /// Запросите необходимую информацию у пользователя и выведите результаты.
    /// </summary>
    public class Task8
    {
        // Константа для числа Пи
        private const double PI = 3.14159265359;

        public static void Run()
        {
            Console.WriteLine("=== Задача 8: Операции с константами ===\n");

            // Расчет площади круга
            Console.WriteLine("=== Расчет площади круга ===");
            Console.Write("Введите радиус круга: ");
            if (!double.TryParse(Console.ReadLine(), out double radius))
            {
                Console.WriteLine("Ошибка: введено некорректное значение!");
                Console.ReadKey();
                return;
            }

            // Формула площади круга: S = π * r²
            double circleArea = PI * radius * radius;
            Console.WriteLine($"Площадь круга с радиусом {radius} = π * {radius}² = {circleArea:F2}");

            // Расчет площади квадрата
            Console.WriteLine("\n=== Расчет площади квадрата ===");
            Console.Write("Введите длину стороны квадрата: ");
            if (!double.TryParse(Console.ReadLine(), out double side))
            {
                Console.WriteLine("Ошибка: введено некорректное значение!");
                Console.ReadKey();
                return;
            }

            // Формула площади квадрата: S = a²
            double squareArea = side * side;
            Console.WriteLine($"Площадь квадрата со стороной {side} = {side}² = {squareArea:F2}");

            Console.WriteLine("\n=== Использованные константы ===");
            Console.WriteLine($"Число Пи (π) = {PI}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

