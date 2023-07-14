// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr, string sep = ", ", int round = 1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double num = Math.Round(arr[i], round);
        if (i < arr.Length - 1) Console.Write($"{num}{sep}");
        else Console.Write($"{num}");
    }
}

double MaxElem(double[] arr, int round = 1)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = Math.Round(arr[i], round);
    }
    return max;
}

double MinElem(double[] arr, int round = 1)
{
    double min = Math.Round(arr[0], round);
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = Math.Round(arr[i], round);
    }
    return min;
}

double DiffMaxMin(double[] arr, int round = 1)
{
    double max = arr[0];
    double min = Math.Round(arr[0], round);
    double diff = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = Math.Round(arr[i], round);
        else { if (arr[i] < min) min = Math.Round(arr[i], round); }
        diff = Math.Round(max - min, round);
    }
    return diff;
}

double[] array = CreateArrayRndDouble(4, 1, 6);
Console.Write("[");
PrintArrayDouble(array);
Console.Write("]");
Console.WriteLine();

double maxElem = MaxElem(array);
double minElem = MinElem(array);
double diffMaxMin = DiffMaxMin(array);
Console.WriteLine($"{maxElem} - {minElem} = {diffMaxMin}");
