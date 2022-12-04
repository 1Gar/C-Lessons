// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (0,0); B (1,1), -> ~1.4
// A (2,4); B (0,7) -> ~3.6

int x1 = 0;
int y1 = 0;

int x2 = 1;
int y2 = 1;

double result = Math.Round((Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))), 1);
Console.WriteLine(result);