using System;

class Program
{
    static void Main()
    {
        // Создание генератора случайных чисел
        Random rand = new Random();

        // Создание массива из 10 случайных целых чисел от 1 до 100
        int[] array = new int[10];
        for (int i = 0; i < 10; i++)
        {
            array[i] = rand.Next(1, 101); // Генерация случайного числа от 1 до 100
        }

        // Вывод массива для наглядности
        Console.WriteLine("Массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Подсчёт количества элементов в отрезке [10, 90]
        int count = 0;
        foreach (int num in array)
        {
            if (num >= 10 && num <= 90)
            {
                count++;
            }
        }

        Console.WriteLine("Количество элементов в отрезке [10, 90]: " + count);
    }
}

