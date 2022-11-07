// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int number = 8;

int[] array = ArrayCreating(number);
ArrayPrint(array);

int[] ArrayCreating(int num)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

void ArrayPrint(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        Console.Write(i < array.Length - 1 ? "," : "");
    }
    Console.Write("]");
    Console.WriteLine();
}

