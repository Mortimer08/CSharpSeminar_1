// Задача 2: Напишите программу, 
// которая на вход принимает два числа
//  и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// По условию - нужно вывести, какое чило большее, какое меньшее
// Но в примере - выводится только максимальное
// Задача решена в соответствии с условием

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Число {number1} больше {number2}");
}
else
{
    Console.WriteLine($"Число {number2} больше {number1}");
}
