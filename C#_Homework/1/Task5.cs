namespace _1
{
    /// <summary>
    /// Задача 5: Инкремент и декремент
    /// Напишите программу, которая объявляет переменную типа int и увеличивает 
    /// ее значение на 1 с помощью оператора инкремента, а затем уменьшает на 1 
    /// с помощью оператора декремента. Выведите результат на экран.
    /// </summary>
    public class Task5
    {
        public static void Run()
        {
            Console.WriteLine("=== Задача 5: Инкремент и декремент ===\n");

            // Инициализация переменной
            int number = 10;
            Console.WriteLine($"Начальное значение: {number}");

            // Префиксный инкремент (++number) - сначала увеличивает, потом использует
            int prefixIncrement = ++number;
            Console.WriteLine($"После префиксного инкремента (++number): {number}, результат операции: {prefixIncrement}");

            // Постфиксный инкремент (number++) - сначала использует, потом увеличивает
            int postfixIncrement = number++;
            Console.WriteLine($"После постфиксного инкремента (number++): {number}, результат операции: {postfixIncrement}");

            // Префиксный декремент (--number) - сначала уменьшает, потом использует
            int prefixDecrement = --number;
            Console.WriteLine($"После префиксного декремента (--number): {number}, результат операции: {prefixDecrement}");

            // Постфиксный декремент (number--) - сначала использует, потом уменьшает
            int postfixDecrement = number--;
            Console.WriteLine($"После постфиксного декремента (number--): {number}, результат операции: {postfixDecrement}");

            Console.WriteLine($"\nИтоговое значение: {number}");

            Console.WriteLine("\n=== Разница между префиксной и постфиксной формами ===");
            int a = 5;
            int b = 5;
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"Префиксный (++a): результат = {++a}, a теперь = {a}");
            Console.WriteLine($"Постфиксный (b++): результат = {b++}, b теперь = {b}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

