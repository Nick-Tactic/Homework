namespace _3.Part2
{
    /// <summary>
    /// Задача 1. Список студентов
    /// Напишите программу, которая создаёт список студентов и позволяет добавлять, 
    /// удалять и выводить их имена.
    /// </summary>
    public class Task1
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 1: Список студентов ===\n");

            // Создание списка студентов
            List<string> students = new List<string>();

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Добавить студента");
                Console.WriteLine("2 - Удалить студента");
                Console.WriteLine("3 - Вывести список студентов");
                Console.WriteLine("0 - Выход");
                Console.Write("Ваш выбор: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите имя студента: ");
                        string? name = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(name))
                        {
                            students.Add(name);
                            Console.WriteLine($"Студент '{name}' добавлен в список.");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: имя не может быть пустым!");
                        }
                        break;

                    case "2":
                        if (students.Count == 0)
                        {
                            Console.WriteLine("Список студентов пуст!");
                            break;
                        }

                        Console.WriteLine("\nСписок студентов:");
                        for (int i = 0; i < students.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {students[i]}");
                        }

                        Console.Write("\nВведите номер студента для удаления: ");
                        if (int.TryParse(Console.ReadLine(), out int index) && 
                            index >= 1 && index <= students.Count)
                        {
                            string removed = students[index - 1];
                            students.RemoveAt(index - 1);
                            Console.WriteLine($"Студент '{removed}' удален из списка.");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: неверный номер!");
                        }
                        break;

                    case "3":
                        if (students.Count == 0)
                        {
                            Console.WriteLine("Список студентов пуст!");
                        }
                        else
                        {
                            Console.WriteLine("\n=== СПИСОК СТУДЕНТОВ ===");
                            for (int i = 0; i < students.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {students[i]}");
                            }
                            Console.WriteLine($"Всего студентов: {students.Count}");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Выход из программы.");
                        Console.ReadKey();
                        return;

                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }
    }
}

