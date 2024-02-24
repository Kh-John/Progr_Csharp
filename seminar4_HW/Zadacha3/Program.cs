using System;

class Program
{
    static void Main()
    {
        // Создаем исходный массив
        int[] array = { 1, 2, 3, 4, 5 };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Переворачиваем массив
        ReverseArray(array);

        // Выводим перевернутый массив
        Console.WriteLine("Перевернутый массив:");
        PrintArray(array);
    }

    // Метод для вывода массива на экран
    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Метод для переворачивания массива
    static void ReverseArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            // Обмен значениями между левым и правым элементами массива
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            // Сдвигаем указатели
            left++;
            right--;
        }
    }
}
