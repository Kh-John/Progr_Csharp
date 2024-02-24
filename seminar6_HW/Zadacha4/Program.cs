// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

using System;

class Program
{
    static void Main(string[] args)
    {
        string inputString = "Hello my world";

        // Разворачиваем строку
        string reversedString = ReverseWords(inputString);

        // Выводим результат
        Console.WriteLine(reversedString);
    }

    static string ReverseWords(string str)
    {
        string[] words = str.Split(' ');

        string reversedString = "";

        for (int i = words.Length - 1; i >= 0; i--)
        {
            reversedString += words[i];

            if (i > 0)
            {
                reversedString += " ";
            }
        }

        return reversedString;
    }
}
