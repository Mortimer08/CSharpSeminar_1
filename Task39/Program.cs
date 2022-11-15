// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void ReverseArray(int[] array)
{
    // int temp = default;
    for (int i = 0; i < array.Length/2; i++)
    {
        // temp = array[i]; можно инициализировать внутри цикла - каждый раз новое значение
        int temp = default;
        array[i] = array[array.Length-i-1];
        array[array.Length-i-1] = temp;
    }
}

int []arr = CreateArrayRndInt(6, 1, 9);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
