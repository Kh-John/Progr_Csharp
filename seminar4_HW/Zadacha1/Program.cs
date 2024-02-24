using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для выхода: ");
            string input = Console.ReadLine( );

            // Проверка на выход из программы
            if (input.ToLower() == "q")
            {
                Console.WriteLine("Выход из программы.");
                break;
            }

            // Попытка парсинга введённой строки в целое число
            if (int.TryParse(input, out int number))
            {
                // Проверка суммы цифр числа на чётность
                if (SumOfDigitsIsEven(number))
                {
                    Console.WriteLine("Сумма цифр числа чётная. Программа завершена.");
                    break;
                }
                else
                {
                    Console.WriteLine("Сумма цифр числа нечётная. Продолжаем.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число или 'q' для выхода.");
            }
        }
    }

    // Метод для проверки чётности суммы цифр числа
    static bool SumOfDigitsIsEven(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10; // Получение последней цифры числа и добавление её к сумме
            num /= 10; // Удаление последней цифры числа
        }
        return sum % 2 == 0; // Возвращаем true, если сумма чётная, иначе false
    }
}
