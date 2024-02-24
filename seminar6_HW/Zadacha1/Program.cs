// Задача 1: Задайте двумерный массив символов (тип char [,]).
//  Создать строку из символов этого массива.


using System;

class Program
{
    static void Main(string[] args)
    {
        char[,] charArray = {
            {'a', 'b', 'c'},
            {'d', 'e', 'f'}
        };

        string str = GetStringFromCharArray(charArray);

        Console.WriteLine(str);
    }

    static string GetStringFromCharArray(char[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        string str = "";

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                str += array[i, j];
            }
        }

        return str;
    }
}
