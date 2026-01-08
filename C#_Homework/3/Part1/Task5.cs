namespace _3.Part1
{
    /// <summary>
    /// Задача 5. Фильтрация элементов
    /// Напишите программу, которая создает массив целых чисел 
    /// и отдельно выводит только четные числа в новом массиве.
    /// </summary>
    public class Task5
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 5: Фильтрация элементов ===\n");

            // Создание массива целых чисел
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            Console.WriteLine("Исходный массив:");
            PrintArray(numbers);

            // Подсчет количества четных чисел
            int evenCount = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
            }

            // Создание нового массива для четных чисел
            int[] evenNumbers = new int[evenCount];
            int index = 0;

            // Заполнение массива четными числами
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers[index] = number;
                    index++;
                }
            }

            Console.WriteLine("\nМассив четных чисел:");
            PrintArray(evenNumbers);

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }

        /// Вспомогательный метод для вывода массива
        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}

