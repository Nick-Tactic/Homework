namespace _3.Part1
{
    /// <summary>
    /// Задача 2. Поиск максимального и минимального значения
    /// Создайте массив из 20 чисел и реализуйте метод, который находит 
    /// и возвращает максимальное и минимальное значение в массиве.
    /// </summary>
    public class Task2
    {
        // Находит максимальное и минимальное значение в массиве, возвращает кортеж (min, max)
        public static (double min, double max) FindMinMax(double[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Массив не может быть пустым");
            }

            double min = array[0];
            double max = array[0];

            // Поиск минимального и максимального значений
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return (min, max);
        }

        public static void Run()
        {
            Console.WriteLine("=== Задача 2: Поиск максимального и минимального значения ===\n");

            // Создание массива из 20 чисел
            double[] numbers = { 3.5, 12.8, 7.2, 45.9, 2.1, 18.6, 33.4, 9.7, 21.3, 5.4,
                                 14.2, 28.9, 6.8, 39.1, 11.5, 25.7, 17.3, 42.6, 8.9, 31.2 };

            Console.WriteLine("Массив из 20 чисел:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]:F1}");
                if (i < numbers.Length - 1)
                {
                    Console.Write(", ");
                }
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            // Вызов метода для поиска минимального и максимального значений
            var (min, max) = FindMinMax(numbers);

            Console.WriteLine($"\nМинимальное значение: {min:F1}");
            Console.WriteLine($"Максимальное значение: {max:F1}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

