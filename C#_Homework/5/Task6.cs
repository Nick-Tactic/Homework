using _5;

namespace _5
{
    /// <summary>
    /// Задача 6*: Объединение данных
    /// Используя LINQ, создайте метод, который объединяет списки студентов и учителей, 
    /// чтобы показать, какого студента ведет каждый учитель 
    /// (можно добавить свойство Teacher в класс Student).
    /// </summary>
    public class StudentWithTeacher : Student
    {
        public Teacher? Teacher { get; set; }

        public StudentWithTeacher(string name, int age, int grade, Teacher? teacher = null) 
            : base(name, age, grade)
        {
            Teacher = teacher;
        }
    }

    public class Task6
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 6: Объединение данных (LINQ) ===\n");

            // Создание списка учителей
            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher("Александр Сидоров", 45, "Математика"),
                new Teacher("Елена Петрова", 38, "Физика"),
                new Teacher("Мария Волкова", 35, "Химия")
            };

            // Создание списка студентов с учителями
            List<StudentWithTeacher> students = new List<StudentWithTeacher>
            {
                new StudentWithTeacher("Иван Петров", 19, 1, teachers[0]),
                new StudentWithTeacher("Мария Сидорова", 20, 2, teachers[0]),
                new StudentWithTeacher("Алексей Козлов", 21, 3, teachers[1]),
                new StudentWithTeacher("Анна Волкова", 19, 1, teachers[2]),
                new StudentWithTeacher("Дмитрий Смирнов", 22, 4, teachers[1])
            };

            // Объединение данных с использованием LINQ
            var teacherStudentPairs = from student in students
                                      where student.Teacher != null
                                      select new
                                      {
                                          Teacher = student.Teacher,
                                          Student = student
                                      };

            // Группировка по учителям
            var groupedByTeacher = teacherStudentPairs.GroupBy(p => p.Teacher.Name);

            Console.WriteLine("=== СТУДЕНТЫ И ИХ УЧИТЕЛЯ ===\n");

            foreach (var group in groupedByTeacher)
            {
                var teacher = group.First().Teacher;
                Console.WriteLine($"Учитель: {teacher!.GetInfo()}");
                Console.WriteLine("Студенты:");
                foreach (var pair in group)
                {
                    Console.WriteLine($"  - {pair.Student.Name}, курс {pair.Student.Grade}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

