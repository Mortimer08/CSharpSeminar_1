// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

System.Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Squars(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"{i}    {i * i}");
        }
    }
    else
    {
        Console.WriteLine("Введено некорректное значение");
    }
}
Squars(number);