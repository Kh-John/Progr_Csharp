using System;

class Program
{
    static void Main()
    {
        // Задаем двумерный массив символов
        char[,] charArray = {
            {'H', 'e', 'l', 'l', 'o'},
            {'W', 'o', 'r', 'l', 'd'}
        };

        // Создаем строку из символов массива
        string str = GetStringFromCharArray(charArray);

        // Выводим результат
        Console.WriteLine("Строка из символов массива: " + str);
    }

    // Метод для создания строки из символов массива
    static string GetStringFromCharArray(char[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        char[] charArray = new char[rows * cols];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                charArray[index] = arr[i, j];
                index++;
            }
        }

        return new string(charArray);
    }
}
