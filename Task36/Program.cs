﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] Array = new int[5];
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1, 100);
}

int SpecialSum(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (i%2 != 0)
        {
            sum += Array[i];
        }
    }
    return sum;
}

for (int i = 0; i < Array.Length; i++)
{
    Console.Write(Array[i] + " ");
}
Console.WriteLine();
Console.WriteLine(SpecialSum(Array));