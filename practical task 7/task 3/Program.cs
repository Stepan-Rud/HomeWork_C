// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) //  matrix.GetLength(1) = 4
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

double[] AverageElemColumn(int[,] matrix, int round = 1)
{
    double[] array = new double[matrix.GetLength(1)];
    int g = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        double sum = 0;
        
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            average = sum / matrix.GetLength(0);
            
        }
            
            array[g] = Math.Round(average, round);
            g++;
    }
    return array;
}

void PrintArray(double[] arr, string sep = ", ", int round = 1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double num = Math.Round(arr[i], round);
        if (i < arr.Length - 1) Console.Write($"{num}{sep}");
        else Console.Write($"{num}");
    }
}
// 1   2   3
// 3   4   7

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
double[] arr = AverageElemColumn(array2d);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(arr);