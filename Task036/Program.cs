﻿Console.Clear();

int[] getArrayRandom(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-10, 99+1);   
    }
    return array;
}

int getSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

void showArray(int[] array)
{
    Console.Write($"[");
    for(int i = 0; i < array.Length; i++)
    {
        if(i != array.Length - 1)
        {Console.Write($"{array[i]},");}
        else
        {Console.Write($"{array[i]}]");}
    }
}

int[] array = getArrayRandom(5);
int sum = getSum(array);
showArray(array);
Console.WriteLine($" -> cумма чисел на нечётных позициях = {sum}");