using System;

class Program
{
    static void Main()
    {
        // Создание генератора случайных чисел
        Random rand = new Random();

        // Создание массива из 10 случайных трехзначных чисел
        int[] array = new int[10];
        for (int i = 0; i < 10; i++)
        {
            array[i] = rand.Next(100, 1000); // Генерация случайного трехзначного числа
        }

        // Вывод массива для наглядности
        Console.WriteLine("Массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Подсчёт количества чётных чисел в массиве
        int count = 0;
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чётных чисел в массиве: " + count);
    }
}
