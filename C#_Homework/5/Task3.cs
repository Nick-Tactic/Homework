using _5;

namespace _5
{
    /// <summary>
    /// Задача 3: Фильтрация
    /// Создайте метод, который фильтрует студентов старше 18 лет и выводит их имена.
    /// Используя LINQ, отфильтруйте студентов, возраст которых больше 18 лет, 
    /// и выведите их имена.
    /// </summary>
    public class Task3
    {
        /// Фильтрует студентов старше 18 лет (без LINQ)
        public static void FilterStudentsOver18(List<Student> students)
        {
            Console.WriteLine("=== Фильтрация без LINQ ===");
            List<string> names = new List<string>();

            foreach (Student student in students)
            {
                if (student.Age > 18)
                {
                    names.Add(student.Name);
                }
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Студентов старше 18 лет не найдено.");
            }
            else
            {
                Console.WriteLine("Студенты старше 18 лет:");
                for (int i = 0; i < names.Count; i++)
                {
                    Console.WriteLine($"  {i + 1}. {names[i]}");
                }
            }
        }

        /// Фильтрует студентов старше 18 лет с использованием LINQ
        public static void FilterStudentsOver18LINQ(List<Student> students)
        {
            Console.WriteLine("\n=== Фильтрация с LINQ ===");
            var filteredStudents = students.Where(s => s.Age > 18).Select(s => s.Name).ToList();

            if (filteredStudents.Count == 0)
            {
                Console.WriteLine("Студентов старше 18 лет не найдено.");
            }
            else
            {
                Console.WriteLine("Студенты старше 18 лет:");
                for (int i = 0; i < filteredStudents.Count; i++)
                {
                    Console.WriteLine($"  {i + 1}. {filteredStudents[i]}");
                }
            }
        }

        public static void Run()
        {
            Console.WriteLine("=== Задача 3: Фильтрация ===\n");

            // Создание списка студентов
            List<Student> students = new List<Student>
            {
                new Student("Иван Петров", 17, 1),
                new Student("Мария Сидорова", 20, 2),
                new Student("Алексей Козлов", 19, 3),
                new Student("Анна Волкова", 18, 1),
                new Student("Дмитрий Смирнов", 22, 4),
                new Student("Елена Новикова", 16, 1)
            };

            Console.WriteLine("Все студенты:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {students[i].GetInfo()}");
            }

            Console.WriteLine();

            // Фильтрация без LINQ
            FilterStudentsOver18(students);

            // Фильтрация с LINQ
            FilterStudentsOver18LINQ(students);

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

