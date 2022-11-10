// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(i < array.Length - 1 ? "," : "");
    }
    Console.WriteLine("]");
}

bool IsNumberInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i]) return true;
    }
    return false;
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string answer = IsNumberInArray(arr, number) ? "присутствует":"отсутствует";
Console.WriteLine($"Число {number} {answer} в массиве");