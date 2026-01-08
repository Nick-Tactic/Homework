namespace _5
{
    /// <summary>
    /// Задача 1: Определение классов
    /// Создайте классы Person, Student и Teacher.
    /// </summary>

    // Базовый класс Person
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /// Возвращает строку с информацией о человеке
        public virtual string GetInfo()
        {
            return $"Имя: {Name}, Возраст: {Age}";
        }
    }

    // Класс Student наследуется от Person
    public class Student : Person
    {
        public int Grade { get; set; } // 1, 2, 3, 4 - курс обучения

        public Student(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
        }

        /// Переопределяет метод родительского класса, добавляя информацию о классе
        public override string GetInfo()
        {
            return base.GetInfo() + $", Курс: {Grade}";
        }
    }

    // Класс Teacher наследуется от Person
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        /// Переопределяет метод родительского класса, добавляя информацию о предмете
        public override string GetInfo()
        {
            return base.GetInfo() + $", Предмет: {Subject}";
        }
    }

    public class Task1
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 1: Определение классов ===\n");

            // Создание объектов классов
            Person person = new Person("Иван Иванов", 30);
            Student student = new Student("Мария Петрова", 20, 2);
            Teacher teacher = new Teacher("Александр Сидоров", 45, "Математика");

            // Вывод информации с помощью метода GetInfo()
            Console.WriteLine("=== Информация о людях ===");
            Console.WriteLine($"Person: {person.GetInfo()}");
            Console.WriteLine($"Student: {student.GetInfo()}");
            Console.WriteLine($"Teacher: {teacher.GetInfo()}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

