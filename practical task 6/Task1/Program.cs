﻿// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите элементы(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int count = NaturalNumb(array);
Console.WriteLine($"Кол-во элементов > 0: {count}");

int NaturalNumb(int[] arr)
{
    int Count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            Count++;
        }
    }
    return Count;
}