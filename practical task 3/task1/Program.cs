// Задача 19
// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number%10 * 10000 + (number/10)%10 * 1000 + (number/100)%10 * 100 + (number/1000)%10 * 10 + number/10000;

string palindrome = palind(number, number1);
string result = palindrome == "Нет"
            ? "Число не палиндром"
            : $"Число палиндром -> {palindrome}";
Console.WriteLine(result);

string palind(int num,int num1)
{
    if (num == num1) return "Да";
    else return "Нет";
}