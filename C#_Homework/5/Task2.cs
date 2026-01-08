using _5;

namespace _5
{
    /// <summary>
    /// Задача 2: Список студентов
    /// Создайте список студентов, используя классы из задачи 1. 
    /// Добавьте несколько студентов в список и распечатайте их информацию, 
    /// вызывая метод GetInfo().
    /// </summary>
    public class Task2
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 2: Список студентов ===\n");

            // Создание списка студентов
            List<Student> students = new List<Student>();

            // Добавление студентов в список
            students.Add(new Student("Иван Петров", 19, 1));
            students.Add(new Student("Мария Сидорова", 20, 2));
            students.Add(new Student("Алексей Козлов", 21, 3));
            students.Add(new Student("Анна Волкова", 19, 1));
            students.Add(new Student("Дмитрий Смирнов", 22, 4));

            // Вывод информации о всех студентах
            Console.WriteLine("=== СПИСОК СТУДЕНТОВ ===\n");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i].GetInfo()}");
            }

            Console.WriteLine($"\nВсего студентов: {students.Count}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

