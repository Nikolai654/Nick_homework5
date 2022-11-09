﻿Console.Clear();

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}
int EvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int all = EvenCount(array);
Console.WriteLine($"Всего четных чисел – {all}");
Footer
