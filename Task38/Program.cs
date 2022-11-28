// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] Array = new double[5] { 1.0, -2.5, 3.14, 9.5, 0 };
double min = Array[0];
double max = Array[0];
for (int i = 1; i < Array.Length; i++)
{
    if (Array[i] > max)
    {
        max = Array[i];
    }
    if (Array[i] < min)
    {
        min = Array[i];
    }
}

double diff = max - min;
Console.WriteLine("Разница между макисимальным и минимальным элементами массива равна " + diff);