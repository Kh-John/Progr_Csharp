// double result = Math.Pow(8, 7);

// Console.WriteLine(result);


// Задание 2. Работа в сессионных залах
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// int a = 487;

//     int y = a % 10;
//     int x = a / 10 % 10;
//     int pow = 1;

//     for (int i = 0; i < y; i++)
//     {
//         pow = pow*x;
//         // pow*=x
//     }

//     Console.WriteLine(pow);

// int a = 14;
// int b = 5;
// int rem = a % b;
// if (rem == 0)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine($"Нет, {rem}");
// }

int a = 456789;
int b = a % 10;

if (a > 99)
{

    System.Console.WriteLine($"{a / 100%10}");

}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}