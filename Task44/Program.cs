// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void FibonacciOutput(int num)
{
    Console.Write("0 1");
    int fibonacci;
    int fibonacci1 = 0;
    int fibonacci2 = 1;
    for (int i = 2; i < num; i++)
    {
        fibonacci = fibonacci1 + fibonacci2;
        Console.Write($" {fibonacci}");
        fibonacci1 = fibonacci2;
        fibonacci2 = fibonacci;
    }
    Console.WriteLine();
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

int[] FibonacciArray(int num)
{
    int[] array = new int [num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
FibonacciOutput(number);
int []fibonacciArray = FibonacciArray(number);
PrintArray(fibonacciArray);