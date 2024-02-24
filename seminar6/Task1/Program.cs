// Задание 1. Совместная работа
// Семинар 6. Массивы и строки
// 15 мин
// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

string ConvertToString(char[] chars)
{
    string str = "";

    for (int i = 0; i < chars.Length; i++)
    {
        str += chars[i];
    }

    return str;
}

char[] chars = {'a', 'b', 'c', 'd', '!'};
string str = ConvertToString(chars);

System.Console.WriteLine(str);





string input = "1234, 5, 67";

var result = input.Split(", ").Select(x => int.Parse(x) * 100).ToArray();

Console.WriteLine(string.Join(", ", result));



// Задание 2. Работа в сессионных залах
// Семинар 6. Массивы и строки
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

char[] ConvertToChars(string str)
{
    int size = str.Length;
    char[] result = new char[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = str[i];
    }
    return result;
}

string str = "Hello!";
char[] array = ConvertToChars(str);
foreach (var e in array)
{
    Console.WriteLine(e);
}

// Задание 3. Совместная работа
// Семинар 6. Массивы и строки
// 20 мин
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

bool IsVowel (char e)
{
    string vowels = "aeiouy";
    for (int i = 0; i < vowels.Length; i++)
    {
        if (e == vowels[i])
        {
            return true;
        }
    } 
    return false;
}

int CountVowels(string str)
{
    int result = 0;
    foreach (var e in str)
    {
        if (IsVowel(e))
        {
            result += 1;
        }
    }
    return result;
}

string str = "world";
Console.WriteLine(CountVowels(str));

14:53
int CountVowels(string str)
{
    int result = 0;
    string vowels = "aeiouy";
    foreach (char e in str)
    {
        if (vowels.Contains(e))
        {
            result += 1;
        }
    }
    return result;
}

string str = "world";
Console.WriteLine(CountVowels(str));




