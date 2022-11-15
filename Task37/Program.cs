// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] MultipliedArray(int[] array)
{
    // int multipliedArrayLenght = array.Length / 2 + array.Length % 2; // Сложно понимаемо
    int multipliedArrayLenght = array.Length / 2;
    if (array.Length % 2 != 0) multipliedArrayLenght++;
    int[] multipliedArray = new int[multipliedArrayLenght];
    for (int i = 0; i < array.Length / 2; i++)
    {
        multipliedArray[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 != 0) multipliedArray[multipliedArrayLenght - 1] = array[array.Length / 2];
    return multipliedArray;
}

int[] arr = CreateArrayRndInt(3, 0, 9);
PrintArray(arr);
int[] multipliedArr = MultipliedArray(arr);
PrintArray(multipliedArr);
