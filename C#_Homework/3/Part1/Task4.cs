namespace _3.Part1
{
    /// <summary>
    /// Задача 4. Объединение массивов
    /// Создайте из двух массивов из 5 целых чисел один массив из 10 чисел.
    /// </summary>
    public class Task4
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 4: Объединение массивов ===\n");

            // Создание двух массивов по 5 элементов
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 6, 7, 8, 9, 10 };

            Console.WriteLine("Первый массив:");
            PrintArray(array1);

            Console.WriteLine("\nВторой массив:");
            PrintArray(array2);

            // Объединение массивов в один массив из 10 элементов
            int[] combined = new int[array1.Length + array2.Length];

            // Копирование элементов первого массива
            for (int i = 0; i < array1.Length; i++)
            {
                combined[i] = array1[i];
            }

            // Копирование элементов второго массива
            for (int i = 0; i < array2.Length; i++)
            {
                combined[array1.Length + i] = array2[i];
            }

            Console.WriteLine("\nОбъединенный массив:");
            PrintArray(combined);

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

