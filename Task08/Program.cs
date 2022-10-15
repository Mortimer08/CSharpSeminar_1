// Задача 8: Напишите программу
// которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int currentNumber = 2;
if (number < 2)
{
    Console.WriteLine("Число не подходит");
}
else
{
    while (currentNumber <= number)
    {
        Console.WriteLine(currentNumber);
        currentNumber = currentNumber + 2;
    }
}