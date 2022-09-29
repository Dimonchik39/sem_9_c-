﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

int DegreeOFNumber(int c, int d)
{
    if (d == 1) return c;
    else
    {
        c *= DegreeOFNumber(c, d - 1);
    }
    return c;
}

int degree = DegreeOFNumber(a, b);
Console.WriteLine(degree);