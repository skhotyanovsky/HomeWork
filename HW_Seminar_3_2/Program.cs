﻿// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

char selection;
Double x1, x2, y1, y2, z1, z2, distance;

Console.WriteLine("Введите координаты точек");

Console.Write("Введите координаты x1: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z1: ");
z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z2: ");
z2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
    