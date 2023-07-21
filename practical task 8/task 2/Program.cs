// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

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

void Matrix(int[,] matrix)
{   
    int sum = 0;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            temp += matrix[i, j];
        }
        if(sum < temp)
        {
        sum = temp;
        index = i;
        }
        
    }
    Console.WriteLine($"Строка - {index} сумма - {sum}");
    
    
}


int[,] array2d = CreateMatrixRndInt(6, 5, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
Matrix(array2d);