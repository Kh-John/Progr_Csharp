using System;

class Program
{
    static void Main()
    {
        // Задаем исходную строку
        string inputString = "HeLLoWoRLd";

        // Формируем строку с заменой заглавных букв на строчные
        string lowercaseString = ConvertToLowerCase(inputString);

        // Выводим результат
        Console.WriteLine("Исходная строка: " + inputString);
        Console.WriteLine("Строка с заменой заглавных букв на строчные: " + lowercaseString);
    }

    // Метод для замены заглавных букв на строчные
    static string ConvertToLowerCase(string input)
    {
        char[] chars = input.ToCharArray(); // Преобразуем строку в массив символов

        for (int i = 0; i < chars.Length; i++)
        {
            // Проверяем, является ли символ заглавной буквой
            if (char.IsUpper(chars[i]))
            {
                // Если символ заглавная буква, заменяем его на соответствующую строчную букву
                chars[i] = char.ToLower(chars[i]);
            }
        }

        // Преобразуем массив символов обратно в строку
        return new string(chars);
    }
}
