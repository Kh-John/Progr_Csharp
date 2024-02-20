﻿// Задание 2. Работа в сессионных залах
// Семинар 7. Рекурсия
// Предварительно обсудить компоненты рекурсии
// Инструктаж по работе в залах
// 20 мин
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5



void RangeOfDigit(int n, int m = 1)
{
    if (m == n)
    {
        Console.WriteLine(m);
        return;
    }
    Console.Write(m + " ");
    RangeOfDigit(n, m + 1);
}
int n = 5;
RangeOfDigit(n);


