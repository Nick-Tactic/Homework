using _5;

namespace _5
{
    /// <summary>
    /// Задача 8: Точка управления
    /// Напишите скрипт управления всеми классами, которое будет:
    /// - Позволять пользователю добавлять студентов и учителей.
    /// - Показывать списки всех студентов и учителей.
    /// - Предоставлять функционал для фильтрации и группировки, описанных в предыдущих задачах.
    /// </summary>
    public class Task8
    {
        private static List<Student> students = new List<Student>();
        private static List<Teacher> teachers = new List<Teacher>();

        public static void Run()
        {
            Console.WriteLine("=== Задача 8: Точка управления ===\n");

            while (true)
            {
                Console.WriteLine("\n=== ГЛАВНОЕ МЕНЮ ===");
                Console.WriteLine("1 - Добавить студента");
                Console.WriteLine("2 - Добавить учителя");
                Console.WriteLine("3 - Показать всех студентов");
                Console.WriteLine("4 - Показать всех учителей");
                Console.WriteLine("5 - Фильтрация студентов (старше 18 лет)");
                Console.WriteLine("6 - Группировка студентов по курсам");
                Console.WriteLine("7 - Поиск учителей по предмету");
                Console.WriteLine("8 - Статистика по предметам");
                Console.WriteLine("0 - Выход");
                Console.Write("Ваш выбор: ");

                string? choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;

                    case "2":
                        AddTeacher();
                        break;

                    case "3":
                        ShowAllStudents();
                        break;

                    case "4":
                        ShowAllTeachers();
                        break;

                    case "5":
                        FilterStudentsOver18();
                        break;

                    case "6":
                        GroupStudentsByGrade();
                        break;

                    case "7":
                        FindTeachersBySubject();
                        break;

                    case "8":
                        ShowSubjectStatistics();
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

        private static void AddStudent()
        {
            Console.WriteLine("=== Добавление студента ===\n");
            Console.Write("Имя: ");
            string? name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Ошибка: имя не может быть пустым!");
                Console.ReadKey();
                return;
            }

            Console.Write("Возраст: ");
            if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
            {
                Console.WriteLine("Ошибка: введен неверный возраст!");
                Console.ReadKey();
                return;
            }

            Console.Write("Курс (1-4): ");
            if (!int.TryParse(Console.ReadLine(), out int grade) || grade < 1 || grade > 4)
            {
                Console.WriteLine("Ошибка: курс должен быть от 1 до 4!");
                Console.ReadKey();
                return;
            }

            students.Add(new Student(name, age, grade));
            Console.WriteLine($"Студент '{name}' успешно добавлен!");
            Console.ReadKey();
        }

        private static void AddTeacher()
        {
            Console.WriteLine("=== Добавление учителя ===\n");
            Console.Write("Имя: ");
            string? name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Ошибка: имя не может быть пустым!");
                Console.ReadKey();
                return;
            }

            Console.Write("Возраст: ");
            if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
            {
                Console.WriteLine("Ошибка: введен неверный возраст!");
                Console.ReadKey();
                return;
            }

            Console.Write("Предмет: ");
            string? subject = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(subject))
            {
                Console.WriteLine("Ошибка: предмет не может быть пустым!");
                Console.ReadKey();
                return;
            }

            teachers.Add(new Teacher(name, age, subject));
            Console.WriteLine($"Учитель '{name}' успешно добавлен!");
            Console.ReadKey();
        }

        private static void ShowAllStudents()
        {
            Console.WriteLine("=== СПИСОК ВСЕХ СТУДЕНТОВ ===\n");
            if (students.Count == 0)
            {
                Console.WriteLine("Список студентов пуст.");
            }
            else
            {
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {students[i].GetInfo()}");
                }
                Console.WriteLine($"\nВсего студентов: {students.Count}");
            }
            Console.ReadKey();
        }

        private static void ShowAllTeachers()
        {
            Console.WriteLine("=== СПИСОК ВСЕХ УЧИТЕЛЕЙ ===\n");
            if (teachers.Count == 0)
            {
                Console.WriteLine("Список учителей пуст.");
            }
            else
            {
                for (int i = 0; i < teachers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {teachers[i].GetInfo()}");
                }
                Console.WriteLine($"\nВсего учителей: {teachers.Count}");
            }
            Console.ReadKey();
        }

        private static void FilterStudentsOver18()
        {
            Console.WriteLine("=== Фильтрация студентов (старше 18 лет) ===\n");
            var filtered = students.Where(s => s.Age > 18).ToList();
            if (filtered.Count == 0)
            {
                Console.WriteLine("Студентов старше 18 лет не найдено.");
            }
            else
            {
                foreach (var student in filtered)
                {
                    Console.WriteLine($"  - {student.GetInfo()}");
                }
            }
            Console.ReadKey();
        }

        private static void GroupStudentsByGrade()
        {
            Console.WriteLine("=== Группировка студентов по курсам ===\n");
            var grouped = students.GroupBy(s => s.Grade).OrderBy(g => g.Key);
            foreach (var group in grouped)
            {
                Console.WriteLine($"Курс {group.Key} ({group.Count()} студент(ов)):");
                foreach (var student in group)
                {
                    Console.WriteLine($"  - {student.Name}, возраст {student.Age}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void FindTeachersBySubject()
        {
            Console.WriteLine("=== Поиск учителей по предмету ===\n");
            Console.Write("Введите название предмета: ");
            string? subject = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(subject))
            {
                Console.WriteLine("Ошибка: предмет не может быть пустым!");
                Console.ReadKey();
                return;
            }

            var found = teachers.Where(t => 
                t.Subject.Equals(subject, StringComparison.OrdinalIgnoreCase)).ToList();
            if (found.Count == 0)
            {
                Console.WriteLine($"Учителей по предмету '{subject}' не найдено.");
            }
            else
            {
                foreach (var teacher in found)
                {
                    Console.WriteLine($"  - {teacher.GetInfo()}");
                }
            }
            Console.ReadKey();
        }

        private static void ShowSubjectStatistics()
        {
            Console.WriteLine("=== Статистика по предметам ===\n");
            var stats = teachers
                .GroupBy(t => t.Subject)
                .Select(g => new { Subject = g.Key, Count = g.Count() })
                .OrderBy(s => s.Subject);

            foreach (var stat in stats)
            {
                Console.WriteLine($"  {stat.Subject}: {stat.Count} учитель(ей)");
            }
            Console.ReadKey();
        }
    }
}

