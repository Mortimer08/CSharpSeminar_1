// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число больше 0: ");

int num = Convert.ToInt32(Console.ReadLine());


int countOfDigits = DigittsCount(num);
Console.WriteLine($"В числе {num} {countOfDigits} цифр");

int DigittsCount(int number)
{
    if (number < 0) number *= -1;
    int count = 0;
    while (number >= 1)
    {
        number /= 10;
        count++;
    }
    return count > 0 ? count : 1;
}