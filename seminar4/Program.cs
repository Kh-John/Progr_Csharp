int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }

    return array;
}

int[] FillArray(int[] array, int minValue, int maxValue)
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine("]");
}


int[] massive = GetRandomArray(10, 0, 10);
PrintArray(massive);

int[] massive2 = GetRandomArray(10, 100, 1000);
PrintArray(massive2);

massive2 = FillArray(massive2, 5, 15);
PrintArray(massive2);

                                // Задание 1. Совместная работа
                                // Семинар 4. Функции
                                // 20 мин
                                // Задайте одномерный массив, заполненный случайными
                                // числами. Определите количество простых чисел в этом
                                // массиве.
                                // Примеры
                                // [1 3 4 19 3] => 3
                                // [4 3 4 1 9 5 21 13] => 3

bool IsPrime(int number)
{   
    if(number == 1)
    {
        return false;
    }   
    for(int i = 2; i < number; i++)
    {
        if(number%i == 0)
        {
            return false;
        } 
                 
        
    }
    return true;
}

int GetCountPrimeNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i <array.Length; i++)
    {
        if(IsPrime(array[i]))
        {
            count++;
            //System.Console.Write(i + " ");
        }
    }
    return count;
}

int[] array = {4, 3, 4, 1, 9, 5, 21, 13, 2};

System.Console.WriteLine(GetCountPrimeNumbers(array));

//  for(int i = 2; i < 22; i++)
//  {
//      System.Console.WriteLine($"{i} {IsPrime(i)}");
//  }

// Задание 3. Совместная работа
// Семинар 4. Функции
// 20 мин
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int ConvertDigitsToNumber (int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        number += array[i] * (int)Math.Pow(10, array.Length - 1 - i);
    }
    return number;
}

int[] array = {2, 3, 1};

int num = ConvertDigitsToNumber(array);

System.Console.WriteLine(num);


// https://www.youtube.com/watch?v=KyFWqbRfWIA&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N
// Stepic
// https://youtu.be/Xk8vRnm6xtc?si=16h07pVSh0C4ecSg
// https://metanit.com/sharp/tutorial/2.8.php
// https://itproger.com/course/csharp/10