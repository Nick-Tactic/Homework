using _5;

namespace _5
{
    /// <summary>
    /// Задача 4: Группировка
    /// Расширьте задачу 3, сгруппируйте студентов по их классу (Grade). 
    /// Выведите информацию о каждом классе и список студентов в нем.
    /// </summary>
    public class Task4
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 4: Группировка ===\n");

            // Создание списка студентов
            List<Student> students = new List<Student>
            {
                new Student("Иван Петров", 19, 1),
                new Student("Мария Сидорова", 20, 2),
                new Student("Алексей Козлов", 21, 3),
                new Student("Анна Волкова", 19, 1),
                new Student("Дмитрий Смирнов", 22, 4),
                new Student("Елена Новикова", 20, 2),
                new Student("Сергей Иванов", 23, 4),
                new Student("Ольга Петрова", 21, 3)
            };

            // Группировка студентов по курсу (Grade)
            var groupedByGrade = students.GroupBy(s => s.Grade).OrderBy(g => g.Key);

            Console.WriteLine("=== ГРУППИРОВКА СТУДЕНТОВ ПО КУРСАМ ===\n");

            foreach (var group in groupedByGrade)
            {
                Console.WriteLine($"Курс {group.Key} ({group.Count()} студент(ов)):");
                foreach (Student student in group)
                {
                    Console.WriteLine($"  - {student.Name}, возраст {student.Age}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

