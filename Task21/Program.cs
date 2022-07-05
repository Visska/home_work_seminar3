/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/
Console.Clear();
Console.WriteLine("Введите координаты точки A x, y, z: ");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
double z = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B x1, y1, z1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

double distanse = Math.Sqrt(( x - x1 )*( x - x1 ) + ( y - y1 )*( y - y1 ) + ( z - z1 )*( z - z1 ));

Console.WriteLine($"Координаты точки A -> x = {x}, y = {y}, z = {z}");
Console.WriteLine($"Координаты точки B -> x1 = {x1}, y1 = {y1}, z1 = {z1}");
Console.WriteLine($"Расстояние между ними в 3D пространстве = {distanse}.");