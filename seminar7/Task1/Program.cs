// Задание 1. Совместная работа
// Семинар 7. Рекурсия
// 15 мин
// Обсудить компоненты рекурсии
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

int SumOfDigits(int number)
{
    
    if(number == 0)
    {
        return 0;
    }
    return number%10 + SumOfDigits(number/10);
}

int number = 123456;
int sum = SumOfDigits(number);
System.Console.WriteLine(sum);