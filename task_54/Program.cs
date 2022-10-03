//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] array = GetArray(5, 5, 10, 100);

void PrintArray()
{
    for (int i = 0; i < 5; i++)
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



void SortingArray()
{
    for (int e = 0; e < 4; e++)
    {
        for (int j = 0; j < 4; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int maxElement = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = maxElement;
                }
            }
        }
    }
}
SortingArray();
PrintArray();