using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "практическая7";
        Console.WriteLine("Здравствуйте");

        Console.Write("\nВведите стоимость 1 часа тренировки: ");
        double price;

        // Блок try-catch ловит буквы при вводе
        try
        {
            price = double.Parse(Console.ReadLine());
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: вы ввели буквы вместо числа!");
            Console.ReadKey();
            return;
        }

        // проверка на корректность цены
        if (price <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: цена должна быть больше 0");
            Console.ReadKey();
            return; // Завершаем программу
        }

        Console.Write("Введите количество посетителей: ");
        int count;

        try
        {
            count = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: вы ввели буквы вместо числа!");
            Console.ReadKey();
            return;
        }

        // проверка на корректность количества посетителей
        if (count <= 0)
        {
            Console.WriteLine("Ошибка: количество посетителей должно быть больше 0");
            Console.ReadKey();
            return; // Завершаем программу
        }

        double totalSum = 0;

        for (int i = 1; i <= count; i++)
        {
            Console.Write("Введите количество часов для посетителя " + i + ": ");
            double hours;

            try
            {
                hours = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: вы ввели буквы вместо числа!");
                Console.ReadKey();
                return;
            }

            if (hours <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: количество часов должно быть больше 0");
                Console.ReadKey();
                return;
            }

            totalSum = totalSum + (hours * price);
        }

        Console.WriteLine("\nОбщая сумма за день: " + totalSum + " руб.");

        Console.ReadKey();
    }
}
