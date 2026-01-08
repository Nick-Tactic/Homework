using System;

namespace CS_Homework
{
    /// <summary>
    /// Главная программа для выбора и запуска заданий
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== ВЫБОР ДОМАШНЕГО ЗАДАНИЯ ===\n");
                Console.WriteLine("ДЗ 1 - Основы C# (8 задач)");
                Console.WriteLine("ДЗ 2 - Условия и циклы (12 задач)");
                Console.WriteLine("ДЗ 3 Часть 1 - Массивы (7 задач)");
                Console.WriteLine("ДЗ 3 Часть 2 - Коллекции (14 задач)");
                Console.WriteLine("ДЗ 4 - Методы и функции (3 задачи)");
                Console.WriteLine("ДЗ 5 - Классы и наследование (8 задач)");
                Console.WriteLine("\n0 - Выход");
                Console.Write("\nВыберите задание: ");

                string? choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        ShowHomework1Menu();
                        break;
                    case "2":
                        ShowHomework2Menu();
                        break;
                    case "3":
                        ShowHomework3Part1Menu();
                        break;
                    case "4":
                        ShowHomework3Part2Menu();
                        break;
                    case "5":
                        ShowHomework4Menu();
                        break;
                    case "6":
                        ShowHomework5Menu();
                        break;
                    case "0":
                        Console.WriteLine("До свидания!");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор! Нажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void ShowHomework1Menu()
        {
            Console.WriteLine("=== ДЗ 1 - Основы C# ===\n");
            Console.WriteLine("1. Объявление переменных");
            Console.WriteLine("2. Константы");
            Console.WriteLine("3. Арифметические операторы");
            Console.WriteLine("4. Операторы сравнения");
            Console.WriteLine("5. Инкремент и декремент");
            Console.WriteLine("6. Преобразование типов данных");
            Console.WriteLine("7. Задача с округлением");
            Console.WriteLine("8. Операции с константами");
            Console.WriteLine("\n0. Назад");
            Console.Write("\nВыберите задачу: ");

            string? choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1": _1.Task1.Run(); break;
                case "2": _1.Task2.Run(); break;
                case "3": _1.Task3.Run(); break;
                case "4": _1.Task4.Run(); break;
                case "5": _1.Task5.Run(); break;
                case "6": _1.Task6.Run(); break;
                case "7": _1.Task7.Run(); break;
                case "8": _1.Task8.Run(); break;
                case "0": return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    Console.ReadKey();
                    break;
            }
        }

        static void ShowHomework2Menu()
        {
            Console.WriteLine("=== ДЗ 2 - Условия и циклы ===\n");
            Console.WriteLine("1. Определение четного или нечетного числа");
            Console.WriteLine("2. Вывод максимального из трех чисел");
            Console.WriteLine("3. Фруктовый выбор");
            Console.WriteLine("4. Сумма чисел от 1 до N");
            Console.WriteLine("5. Факториал числа");
            Console.WriteLine("6. Числа Фибоначчи");
            Console.WriteLine("7. Проверка палиндрома");
            Console.WriteLine("8. Поиск максимального числа");
            Console.WriteLine("9. Таблица умножения");
            Console.WriteLine("10. Числовая угадайка");
            Console.WriteLine("11. Симулятор боя с боссом");
            Console.WriteLine("12. Генератор подземелья");
            Console.WriteLine("\n0. Назад");
            Console.Write("\nВыберите задачу: ");

            string? choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1": _2.Task1.Run(); break;
                case "2": _2.Task2.Run(); break;
                case "3": _2.Task3.Run(); break;
                case "4": _2.Task4.Run(); break;
                case "5": _2.Task5.Run(); break;
                case "6": _2.Task6.Run(); break;
                case "7": _2.Task7.Run(); break;
                case "8": _2.Task8.Run(); break;
                case "9": _2.Task9.Run(); break;
                case "10": _2.Task10.Run(); break;
                case "11": _2.Task11.Run(); break;
                case "12": _2.Task12.Run(); break;
                case "0": return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    Console.ReadKey();
                    break;
            }
        }

        static void ShowHomework3Part1Menu()
        {
            Console.WriteLine("=== ДЗ 3 Часть 1 - Массивы ===\n");
            Console.WriteLine("1. Сумма элементов массива");
            Console.WriteLine("2. Поиск максимального и минимального значения");
            Console.WriteLine("3. Реверс массива");
            Console.WriteLine("4. Объединение массивов");
            Console.WriteLine("5. Фильтрация элементов");
            Console.WriteLine("6. Инвентарь героя");
            Console.WriteLine("7. Таблица урона");
            Console.WriteLine("\n0. Назад");
            Console.Write("\nВыберите задачу: ");

            string? choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1": _3.Part1.Task1.Run(); break;
                case "2": _3.Part1.Task2.Run(); break;
                case "3": _3.Part1.Task3.Run(); break;
                case "4": _3.Part1.Task4.Run(); break;
                case "5": _3.Part1.Task5.Run(); break;
                case "6": _3.Part1.Task6.Run(); break;
                case "7": _3.Part1.Task7.Run(); break;
                case "0": return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    Console.ReadKey();
                    break;
            }
        }

        static void ShowHomework3Part2Menu()
        {
            Console.WriteLine("=== ДЗ 3 Часть 2 - Коллекции ===\n");
            Console.WriteLine("1. Список студентов");
            Console.WriteLine("2. Словарь переводов");
            Console.WriteLine("3. Стек и обратный порядок");
            Console.WriteLine("4. Очередь для обслуживания клиентов");
            Console.WriteLine("5. Набор уникальных чисел");
            Console.WriteLine("6. Ведение счетов");
            Console.WriteLine("7. Поиск дубликатов в списке");
            Console.WriteLine("8. Словарь частоты слов");
            Console.WriteLine("9. Объединение списков с уникальными значениями");
            Console.WriteLine("10. Найти максимальное и минимальное значение");
            Console.WriteLine("11. Подсчет чисел, превышающих заданное значение");
            Console.WriteLine("12. Базовый инвентарь");
            Console.WriteLine("13. Имитация сражения игрока с монстрами");
            Console.WriteLine("14. Очередь в таверне");
            Console.WriteLine("\n0. Назад");
            Console.Write("\nВыберите задачу: ");

            string? choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1": _3.Part2.Task1.Run(); break;
                case "2": _3.Part2.Task2.Run(); break;
                case "3": _3.Part2.Task3.Run(); break;
                case "4": _3.Part2.Task4.Run(); break;
                case "5": _3.Part2.Task5.Run(); break;
                case "6": _3.Part2.Task6.Run(); break;
                case "7": _3.Part2.Task7.Run(); break;
                case "8": _3.Part2.Task8.Run(); break;
                case "9": _3.Part2.Task9.Run(); break;
                case "10": _3.Part2.Task10.Run(); break;
                case "11": _3.Part2.Task11.Run(); break;
                case "12": _3.Part2.Task12.Run(); break;
                case "13": _3.Part2.Task13.Run(); break;
                case "14": _3.Part2.Task14.Run(); break;
                case "0": return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    Console.ReadKey();
                    break;
            }
        }

        static void ShowHomework4Menu()
        {
            Console.WriteLine("=== ДЗ 4 - Методы и функции ===\n");
            Console.WriteLine("1. Генерация награды после боя");
            Console.WriteLine("2. Прокачка персонажа");
            Console.WriteLine("3. Инвентарь с ограничением по весу");
            Console.WriteLine("\n0. Назад");
            Console.Write("\nВыберите задачу: ");

            string? choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1": _4.Task1.Run(); break;
                case "2": _4.Task2.Run(); break;
                case "3": _4.Task3.Run(); break;
                case "0": return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    Console.ReadKey();
                    break;
            }
        }

        static void ShowHomework5Menu()
        {
            Console.WriteLine("=== ДЗ 5 - Классы и наследование ===\n");
            Console.WriteLine("1. Определение классов");
            Console.WriteLine("2. Список студентов");
            Console.WriteLine("3. Фильтрация");
            Console.WriteLine("4. Группировка");
            Console.WriteLine("5. Учителя и предметы");
            Console.WriteLine("6. Объединение данных (LINQ)");
            Console.WriteLine("7. Статистика по предметам");
            Console.WriteLine("8. Точка управления");
            Console.WriteLine("\n0. Назад");
            Console.Write("\nВыберите задачу: ");

            string? choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1": _5.Task1.Run(); break;
                case "2": _5.Task2.Run(); break;
                case "3": _5.Task3.Run(); break;
                case "4": _5.Task4.Run(); break;
                case "5": _5.Task5.Run(); break;
                case "6": _5.Task6.Run(); break;
                case "7": _5.Task7.Run(); break;
                case "8": _5.Task8.Run(); break;
                case "0": return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}

