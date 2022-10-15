// S7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Ведите трёхзначное число");

int number = Convert.ToInt32(Console.ReadLine());
if (number > 100 && number < 999)
{
    // int number2 = (number / 10) * 10;
    // int number2 = (number2 * 10);
    // int number = number - number2;
    Console.WriteLine($"Последняя цифра: {number % 10}");

}
else
{
    Console.WriteLine("Введено неверное число");
}