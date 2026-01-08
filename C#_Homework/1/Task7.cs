namespace _1
{
    /// <summary>
    /// Задача 7*: Задача с округлением
    /// Напишите программу, которая запрашивает у пользователя дробное число, 
    /// округляет его до ближайшего целого и выводит результат. 
    /// Используйте методы класса Math для округления.
    /// </summary>
    public class Task7
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 7: Задача с округлением ===\n");

            // Запрос дробного числа
            Console.Write("Введите дробное число: ");
            if (!double.TryParse(Console.ReadLine(), out double number))
            {
                Console.WriteLine("Ошибка: введено некорректное значение!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"\nИсходное число: {number}\n");

            // Math.Round - округление до ближайшего целого
            // Round: округляет до ближайшего целого (0.5 округляется к четному)
            double rounded = Math.Round(number);
            Console.WriteLine($"Math.Round({number}) = {rounded} (округление до ближайшего целого)");

            // Math.Ceiling - округление вверх (к большему целому)
            // Ceiling: всегда округляет вверх
            double ceiling = Math.Ceiling(number);
            Console.WriteLine($"Math.Ceiling({number}) = {ceiling} (округление вверх)");

            // Math.Floor - округление вниз (к меньшему целому)
            // Floor: всегда округляет вниз
            double floor = Math.Floor(number);
            Console.WriteLine($"Math.Floor({number}) = {floor} (округление вниз)");

            // Math.Truncate - отбрасывание дробной части
            // Truncate: просто отбрасывает дробную часть (как Floor для положительных чисел)
            double truncated = Math.Truncate(number);
            Console.WriteLine($"Math.Truncate({number}) = {truncated} (отбрасывание дробной части)");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

