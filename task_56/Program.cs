// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int sumStr1Arr = 0;
int sumStr2Arr = 0;
int sumStr3Arr = 0;
int sumStr4Arr = 0;

int[,] GetArray(int size, int size2, int minValue, int maxValue)
{
    int[,] array2d = new int[size, size2];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            array2d[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array2d;
}

int[,] array = GetArray(4, 5, 1, 10);

void PrintArray()
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write($"|{array[i, j]}|");
        }
        Console.WriteLine();
    }
}
PrintArray();
Console.WriteLine();


for (int j = 0; j < 5; j++)
{
    for (int i = 1; i < 2; i++)
    {
        sumStr1Arr += array[i, j];
    }
}
Console.WriteLine(sumStr1Arr);
Console.WriteLine();

for (int j = 0; j < 5; j++)
{
    for (int i = 2; i < 3; i++)
    {
        sumStr2Arr += array[i, j];
    }
}
Console.WriteLine(sumStr2Arr);
Console.WriteLine();

for (int j = 0; j < 5; j++)
{
    for (int i = 3; i < 4; i++)
    {
        sumStr3Arr += array[i, j];
    }
}
Console.WriteLine(sumStr3Arr);
Console.WriteLine();

for (int j = 0; j < 5; j++)
{
    for (int i = 4; i == 4; i++)
    {
        sumStr4Arr += array[i, j];
    }
}
Console.WriteLine(sumStr4Arr);
Console.WriteLine();