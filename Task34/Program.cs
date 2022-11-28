// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Array = new int[10];
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(100, 1000);
}

int EvenCount(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

for (int i = 0; i < Array.Length; i++)
{
    Console.Write(Array[i] + " ");
}
Console.WriteLine();
Console.WriteLine(EvenCount(Array));