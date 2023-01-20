﻿// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координату x1: ");
int x1=int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y1: ");
int y1=int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z1: ");
int z1=int.Parse(Console.ReadLine()!);

Console.Write("Введите координату x2: ");
int x2=int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y2: ");
int y2=int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z2: ");
int z2=int.Parse(Console.ReadLine()!);

double result=Math.Sqrt((Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)));  // D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)

Console.WriteLine($"Расстояние между заданными точками {result:F3}");   //или округление через {result:F3}, где F3-количество цифр после запятой