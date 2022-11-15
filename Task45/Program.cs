// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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

int[] CopyArray(int[] arr)
{
    int[] copiedArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copiedArr[i] = arr[i];
    }
    return copiedArr;
}

int[] array = CreateArrayRndInt(10, 0, 10);
PrintArray(array);
int[] copiedArray = CopyArray(array);
PrintArray(copiedArray);