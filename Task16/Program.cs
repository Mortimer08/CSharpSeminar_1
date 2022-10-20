// Напишите программу, которая проверяет, является ли одно введённое число квадратом другого

Console.WriteLine("Введите два числа");
Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 * number1 == number2 || number2 * number2 == number1)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

bool IsSquare(int num1, int num2)
{
    if (num1 * num1 == num2 || num2 * num2 == num1) return true;
    return false;
}

Console.WriteLine(IsSquare(number1, number2) ? "Да" : "Нет");