﻿// Задание 1. Совместная работа
// Семинар 3. Массивы
// 15 мин
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// int[] arr = {1, 3, 4, 19, 3};
// int a = 3;
// bool inArray = false;

// /*for(int i = 0; i<arr.Length;i++)
// {
//     if(a == arr[i])
//     {
//         inArray = true;
//         //System.Console.WriteLine("Да");
//     }
    
// }*/

// foreach(int i in arr)
// {
//     if(a == i)
//     {
//         inArray = true;
//     }
// }

// if(inArray)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }
                                // Задание 2. Работа в сессионных залах
                                // Семинар 3. Массивы
                                // Задайте массив из 10 элементов, заполненный числами из
                                // промежутка [-10, 10]. Замените отрицательные элементы на
                                // положительные, а положительные на отрицательные.
                                // Пример
                                // [1 -5 6]
                                // => [-1 5 -6]
int [] a ={1,-5,-6};
for (int i = 0; i < a.Length; i++)
{
    a[i] = a[i]*(-1);
}
for (int i = 0; i < a.Length; i++)
{
    System.Console.Write($"{a[i]} ");
}