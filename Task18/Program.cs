﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

string Diap(int qNumber)
{
    if (qNumber == 1) return "x > 0 и y > 0";
    if (qNumber == 2) return "x < 0 и y > 0";
    if (qNumber == 3) return "x < 0 и y < 0";
    if (qNumber == 4) return "x > 0 и y < 0";
    return "Введено некорректное значение";
}

string result = Diap(quarter);

Console.WriteLine(result);