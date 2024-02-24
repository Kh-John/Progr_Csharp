// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System;

class Program
{
    static void Main(string[] args)
    {
        string inputString = "aBcD1ef!-";

        string resultString = ConvertToLowerCase(inputString);

        Console.WriteLine(resultString);
    }

    static string ConvertToLowerCase(string input)
    {
        string result = "";

        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                result += char.ToLower(c);
            }
            else
            {
                result += c;
            }
        }

        return result;
    }
}
