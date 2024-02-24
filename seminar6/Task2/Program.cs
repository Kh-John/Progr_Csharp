// Задание 2. Работа в сессионных залах
// Семинар 6. Массивы и строки
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.cd
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