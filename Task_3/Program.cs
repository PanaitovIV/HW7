// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

int[,] CreateArray(int m = 3, int n = 4)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array, string msg)
{
    System.Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine();
}

double[] FindAVG(int[,] array)
{
    double[] avg = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            avg[j] += array[i, j];
        }
    }
    for (int i = 0; i < avg.Length; i++)
    {
        avg[i] /= array.GetLength(0);
    }
    return avg;
}

void PrintAVG(double[] array)
{
    System.Console.WriteLine("Среднее арифметическое значение каждого столбца:");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) 
        {
            System.Console.Write($"{array[i]:F3}; ");
        }
        else 
        {
            System.Console.Write($"{array[i]:F3}");
        }
    }
}

int[,] resultArray = CreateArray();
PrintArray(resultArray, "Наш massiv:");
double[] average = FindAVG(resultArray);
PrintAVG(average);