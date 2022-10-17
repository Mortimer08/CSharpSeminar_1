int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
// int digit1 = number % 10;
// int digit2 = number / 10;

// if (digit1 > digit2) Console.WriteLine($"Максимальная цифра числа => {digit1}");
// else Console.WriteLine($"Максимальная цифра числа => {digit2}");
// int res = Math.Max(digit1,digit2);
// System.Console.WriteLine(res);

//int maxdigit = digit1 > digit2 ? digit1 : digit2; //тернарный оператор
// Console.Write($"Наибольшая цифра числа {number} равна ");
// Console.WriteLine(digit1 > digit2 ? digit1 : digit2);

// Решение через метод

int MaxDigit(int num)
{
    int digit1 = num % 10;
    int digit2 = num / 10;    
    return digit1 > digit2 ? digit1 : digit2;
}

int maxDigit = MaxDigit(number);
System.Console.WriteLine($"Наибольшая цифра числа {number} равна {maxDigit}");
int maxDigit1 = MaxDigit(67);
System.Console.Write($"Наибольшая цифра 67 числа равна ");
System.Console.WriteLine(maxDigit1);
