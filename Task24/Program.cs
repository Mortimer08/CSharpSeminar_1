// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
using System;

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(num));

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i < number+1; i ++)
    {
        sum += i;
    }
    return sum;
}