using _5;

namespace _5
{
    /// <summary>
    /// Задача 7: Статистика по предметам
    /// Выведите статистику по предметам: сколько учителей по каждому предмету.
    /// Используя LINQ, выведите статистику по предметам: сколько учителей по каждому предмету. 
    /// Результат должен быть в виде объекта, который содержит имя предмета и количество учителей.
    /// </summary>
    public class Task7
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 7: Статистика по предметам ===\n");

            // Создание списка учителей
            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher("Александр Сидоров", 45, "Математика"),
                new Teacher("Елена Петрова", 38, "Физика"),
                new Teacher("Иван Козлов", 42, "Математика"),
                new Teacher("Мария Волкова", 35, "Химия"),
                new Teacher("Дмитрий Смирнов", 50, "Физика"),
                new Teacher("Анна Новикова", 40, "Биология"),
                new Teacher("Сергей Иванов", 48, "Математика")
            };

            Console.WriteLine("Все учителя:");
            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {teachers[i].GetInfo()}");
            }

            // Статистика без LINQ
            Console.WriteLine("\n=== Статистика без LINQ ===");
            Dictionary<string, int> stats = new Dictionary<string, int>();
            foreach (Teacher teacher in teachers)
            {
                if (stats.ContainsKey(teacher.Subject))
                {
                    stats[teacher.Subject]++;
                }
                else
                {
                    stats[teacher.Subject] = 1;
                }
            }

            foreach (var stat in stats.OrderBy(s => s.Key))
            {
                Console.WriteLine($"  {stat.Key}: {stat.Value} учитель(ей)");
            }

            // Статистика с LINQ
            Console.WriteLine("\n=== Статистика с LINQ ===");
            var statistics = teachers
                .GroupBy(t => t.Subject)
                .Select(g => new { Subject = g.Key, Count = g.Count() })
                .OrderBy(s => s.Subject);

            foreach (var stat in statistics)
            {
                Console.WriteLine($"  {stat.Subject}: {stat.Count} учитель(ей)");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

