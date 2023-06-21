// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X точки A: ");
int XA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
int YA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки A: ");
int ZA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X точки B: ");
int XB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int YB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int ZB = Convert.ToInt32(Console.ReadLine());

double num = Math.Round((Math.Sqrt((Math.Pow((XB - XA),2)) + (Math.Pow((YB - YA),2)) + (Math.Pow((ZB - ZA),2)))), 2);

Console.Write(num);
