namespace _3.Part2
{
    /// <summary>
    /// Задача 9. Объединение списков с уникальными значениями
    /// Создайте два списка целых чисел и объедините их, сохранив только уникальные значения.
    /// </summary>
    public class Task9
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 9: Объединение списков с уникальными значениями ===\n");

            // Создание первого списка
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Первый список:");
            PrintList(list1);

            // Создание второго списка
            List<int> list2 = new List<int> { 5, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine("\nВторой список:");
            PrintList(list2);

            // Объединение списков с сохранением только уникальных значений
            // Используем HashSet для автоматического удаления дубликатов
            HashSet<int> uniqueSet = new HashSet<int>(list1);
            uniqueSet.UnionWith(list2);

            // Преобразование обратно в список
            List<int> mergedList = uniqueSet.ToList();
            mergedList.Sort(); // Сортировка для удобства просмотра

            Console.WriteLine("\nОбъединенный список (только уникальные значения):");
            PrintList(mergedList);

            Console.WriteLine($"\nВсего элементов в первом списке: {list1.Count}");
            Console.WriteLine($"Всего элементов во втором списке: {list2.Count}");
            Console.WriteLine($"Уникальных элементов в объединенном списке: {mergedList.Count}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }

        /// Вспомогательный метод для вывода списка
        private static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}");
                if (i < list.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}

