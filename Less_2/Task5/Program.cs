int n = 5;
int[] array = { 8, 5, 7, 2, 6 };
int i = 0;
int max = array[0];
while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
System.Console.WriteLine(max);