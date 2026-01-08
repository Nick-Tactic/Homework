namespace _3.Part1
{
    /// <summary>
    /// Задача 3. Реверс массива
    /// Напишите программу, которая создает массив из 10 целых чисел 
    /// и выводит его в обратном порядке.
    /// </summary>
    public class Task3
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 3: Реверс массива ===\n");

            // Создание массива из 10 целых чисел
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}");
                if (i < numbers.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            // Вывод массива в обратном порядке
            Console.WriteLine("\n\nМассив в обратном порядке:");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]}");
                if (i > 0)
                {
                    Console.Write(", ");
                }
            }

            // Альтернативный способ: создание нового массива в обратном порядке
            int[] reversed = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                reversed[i] = numbers[numbers.Length - 1 - i];
            }

            Console.WriteLine("\n\nНовый массив (реверс исходного):");
            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write($"{reversed[i]}");
                if (i < reversed.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

