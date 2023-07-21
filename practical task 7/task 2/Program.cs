// Задача 50. Напишите программу, которая на вход принимает
//  позиции элемента в двумерном массиве, и возвращает
//  значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

void FindElementValue(int[,] Matrix, int Row, int Col)
{
    int Rows = Matrix.GetLength(0); //Можно и без переменных,
    int Cols = Matrix.GetLength(1); //но очень длинная запись
    if (Row >= 0 && Row < Rows && Col >= 0 && Col < Cols)
    {
        
        Console.WriteLine(Matrix[Row, Col]);
    }
    else
    {
        Console.WriteLine("Заданного элемента нет");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);

Console.Write("Введите позицию строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию колонки: ");
int col = Convert.ToInt32(Console.ReadLine());

FindElementValue(array2d, row, col);