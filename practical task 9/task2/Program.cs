// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = NaturalNumbers(number1, number2) - number2;
Console.WriteLine($"M = {number1}; N = {number2} -> {result}");

int NaturalNumbers(int num1, int num2) // 5
{
    int sum = 0;
    if (num1 < num2)
    {   
        sum = num1;
        return sum + NaturalNumbers(num1+ 1, num2);
         
    }
    else if (num1 > num2)
    {   
        sum = num1;
        return sum + NaturalNumbers(num1 - 1, num2);
        

    }
    else
    {
        sum = num1 + num2;
        return sum;
    }
    
}