namespace _3.Part2
{
    /// <summary>
    /// Задача 3. Стек и обратный порядок
    /// Напишите программу, которая использует стек для ввода строк 
    /// и печатает их в обратном порядке.
    /// </summary>
    public class Task3
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 3: Стек и обратный порядок ===\n");
            Console.WriteLine("Введите строки (введите 'стоп' для завершения ввода):\n");

            // Создание стека для хранения строк
            Stack<string> stack = new Stack<string>();

            // Ввод строк
            while (true)
            {
                Console.Write("Введите строку: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ошибка: введена пустая строка!");
                    continue;
                }

                if (input.ToLower() == "стоп")
                {
                    break;
                }

                // Добавление строки в стек
                stack.Push(input);
            }

            // Вывод строк в обратном порядке
            Console.WriteLine("\n=== Строки в обратном порядке ===");
            if (stack.Count == 0)
            {
                Console.WriteLine("Стек пуст.");
            }
            else
            {
                int count = stack.Count;
                while (stack.Count > 0)
                {
                    string item = stack.Pop();
                    Console.WriteLine($"{count - stack.Count}. {item}");
                }
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

