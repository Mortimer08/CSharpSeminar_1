// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25; b = 5 -> да
// a = 10; b = 2 -> нет
// a = -3; b = 9 -> нет
// a = 9; b = -3 -> да

Console.Write("Ведите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int square = number2 * number2;

if(number1 == square)
{
    Console.WriteLine("Первое число - квадрат второго! Совпадение?!");
}
else
{
    Console.WriteLine("Первое число - НЕ квадрат второго!");
}