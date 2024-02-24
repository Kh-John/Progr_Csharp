// Задайте произвольную строку. Выясните, является ли она палиндромом.


using System;

class Program
{
    static void Main(string[] args)
    {
        string inputString = "5446445";

        string result = IsPalindrome(inputString) ? "да" : "нет";

        Console.WriteLine($"Строка является палиндромом? {result}");
    }

    static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
