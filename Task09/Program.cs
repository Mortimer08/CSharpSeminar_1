int number = new Random().Next(10,100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
int digit1 = number % 10;
int digit2 = number / 10;

if (digit1 > digit2) Console.WriteLine($"Максимальная цифра числа => {digit1}");
else Console.WriteLine($"Максимальная цифра числа => {digit2}");