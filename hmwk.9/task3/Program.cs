﻿// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermanFn(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermanFn(m - 1, 1);
    return AckermanFn(m - 1, AckermanFn(m, n - 1));
}

Console.Clear();
int m = ReadInput("Введите чило M: ");
int n = ReadInput("Введите чило N: ");

System.Console.WriteLine($"Значение функции Аккермана равно: {AckermanFn(m, n)}");