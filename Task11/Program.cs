// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет из него вторую цифру
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число => {number}");

// int digit1 = number / 100;
// int digit3 = number % 10;

// int newNumber = digit1 * 10 + digit3;
// Console.WriteLine($"Получилось число {newNumber}");

int RemoveSecondDigit(int num)
{
    int res = default;
    int digit1 = num / 100;
    int digit3 = num % 10;
    res = digit1 * 10 + digit3;
    return res;
}

int newNumber = RemoveSecondDigit(number);
Console.WriteLine($"Получилось число {newNumber}");
