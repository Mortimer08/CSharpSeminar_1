// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты двух точек");
Console.Write("Первая точка, координата X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();~
Console.Write("Первая точка, координата Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
Console.Write("Вторая точка, координата X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();~
Console.Write("Вторая точка, координата Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xc1, int yc1, int xc2, int yc2)
{
    int rx = xc1 - xc2;
    int ry = yc1 - yc2;
    return Math.Sqrt(rx * rx + ry * ry);
}

double result = Math.Round(Distance(x1, y1, x2, y2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {result}");