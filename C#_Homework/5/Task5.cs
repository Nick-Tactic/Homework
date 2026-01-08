using _5;

namespace _5
{
    /// <summary>
    /// Задача 5: Учителя и предметы
    /// Создайте список учителей и добавьте в него несколько объектов класса Teacher. 
    /// Напишите метод, который позволяет находить учителей по предмету 
    /// и выводить их информацию.
    /// </summary>
    public class Task5
    {
        // Находит учителей по предмету и выводит их информацию
        public static void FindTeachersBySubject(List<Teacher> teachers, string subject)
        {
            var foundTeachers = teachers.Where(t => 
                t.Subject.Equals(subject, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundTeachers.Count == 0)
            {
                Console.WriteLine($"Учителей по предмету '{subject}' не найдено.");
            }
            else
            {
                Console.WriteLine($"\nУчителя по предмету '{subject}':");
                for (int i = 0; i < foundTeachers.Count; i++)
                {
                    Console.WriteLine($"  {i + 1}. {foundTeachers[i].GetInfo()}");
                }
            }
        }

        public static void Run()
        {
            Console.WriteLine("=== Задача 5: Учителя и предметы ===\n");

            // Создание списка учителей
            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher("Александр Сидоров", 45, "Математика"),
                new Teacher("Елена Петрова", 38, "Физика"),
                new Teacher("Иван Козлов", 42, "Математика"),
                new Teacher("Мария Волкова", 35, "Химия"),
                new Teacher("Дмитрий Смирнов", 50, "Физика"),
                new Teacher("Анна Новикова", 40, "Биология")
            };

            Console.WriteLine("Все учителя:");
            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {teachers[i].GetInfo()}");
            }

            // Поиск учителей по предмету
            Console.WriteLine("\n=== ПОИСК УЧИТЕЛЕЙ ПО ПРЕДМЕТУ ===");
            Console.Write("Введите название предмета: ");
            string? subject = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(subject))
            {
                FindTeachersBySubject(teachers, subject);
            }
            else
            {
                Console.WriteLine("Ошибка: предмет не может быть пустым!");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

