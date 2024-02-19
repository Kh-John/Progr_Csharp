/*
Задание 3. Совместная работа
Семинар 7. Рекурсия
20 мин
Считать строку с консоли, содержащую латинские буквы.
Вывести на экран согласные буквы этой строки.
Указание
Использовать рекурсию. Не использовать цикл.
Пример
“hello” => h l l
“World” => W r l d
“Hello world!” => H l l w r l d
 */


bool IsLetter(char ch)
{
    return ('a' <= ch && ch <= 'z') || ('A' <= ch && ch <= 'Z');
}

bool IsVowel(char ch)
{
    // string vowels = "aeoiuy"; //только строчные
    // vowels += vowels.ToUpper();
    string vowels = "aeoiuyAEOIUY";
    for (int i = 0; i < vowels.Length; i++)
    {
        if (ch == vowels[i])
        {
            return true;
        }
    }

    return false;
}

void PrintConsonants(string word, int i = 0)
{
    if (i >= word.Length)
    {
        return;
    }

    //if (char.IsLetter(word[i]) && !vowels.Contains(word[i]))
    if (IsLetter(word[i]) && !IsVowel(word[i]))
    {
        Console.Write(word[i] + " ");
    }

    PrintConsonants(word, i + 1);
}


PrintConsonants("*Q#RT*NCOY(*MP@E)WA(UR(*AY)Nn2yrv9osyryx3uwEFESB6A");