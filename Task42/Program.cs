// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int DecToBinar(int num)
{
    int result = 0;
    int factor = 1;
    while (num > 0)
    {
        result += factor * (num % 2);
        num /= 2;
        factor *= 10;
    }
    return result;
}

int DecToBinarRecource(int num)
{
    if (num / 2 > 0) return DecToBinarRecource(num / 2);
    return num % 2;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DecToBinar(number));
Console.WriteLine(DecToBinarRecource(number));