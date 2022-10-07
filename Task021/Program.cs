// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координаты точки A1 по оси X");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A1 по оси Y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A2 по оси X");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A2 по оси Y");
int y2 = Convert.ToInt32(Console.ReadLine());
double d = Math.Round(Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2)),2);
Console.WriteLine("Расстояние A1 до A2 = " + d);