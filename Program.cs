
//*********************************************************************************************
//*практическая работа №9 варииант 8                                                          *
//*Выполнил Тарасов Александр группа 2ИСПд                                                    *
//*задание составить программу для нахождения минимального четного элемента массива           *
//*********************************************************************************************

using System;
namespace PracticalWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Переменная для повторного запуска программы
            bool runAgain = true;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Практическая работа №9. Задание 8 ===");
                Console.WriteLine();

                // Создаем массив из 10 элементов
                int[] numbers = new int[10];
                Random random = new Random();

                // Заполняем массив случайными числами от -20 до 20
                Console.WriteLine("Сгенерированный массив:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = random.Next(-20, 21);
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();

                // Обработка ошибок (try-catch)
                try
                {
                    // поиск наименьшего элемента на четных местах.
                    

                    int minEvenPos = int.MaxValue;
                    bool found = false;

                    for (int i = 1; i < numbers.Length; i += 2)
                    {
                        if (numbers[i] < minEvenPos)
                        {
                            minEvenPos = numbers[i];
                            found = true;
                        }
                    }

                    // Вывод результата
                    if (found)
                    {
                        Console.WriteLine("Наименьший элемент на четном месте: " + minEvenPos);
                    }
                    else
                    {
                        
                        Console.WriteLine("Такого элемента нет. Первый элемент массива: " + numbers[0]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка при обработке массива: " + ex.Message);
                }

                // Многократное выполнение без повторного запуска
                Console.WriteLine();
                Console.Write("Хотите выполнить программу еще раз? Нажмите (y): ");
                string choice = Console.ReadLine();

                if (choice.ToLower() != "y" && choice.ToLower() != "н")
                {
                    runAgain = false;
                }

            } while (runAgain);

            Console.WriteLine("Программа завершена.");
        }
    }
}
