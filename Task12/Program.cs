// Напишите программу

Console.WriteLine("Введите два числа");
Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
    Console.WriteLine($"Число {number1} кратно числу {number2}");
}
else
{
    Console.WriteLine($"Остаток от деления числа {number1} на {number2} составляет {number1 % number2}");
}