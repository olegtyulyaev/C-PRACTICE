﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Clear();
Console.WriteLine("Введите число :  ");
int N = int.Parse(Console.ReadLine());
    
for (int i = 2; i <= N; i += 2)
Console.WriteLine(i);

