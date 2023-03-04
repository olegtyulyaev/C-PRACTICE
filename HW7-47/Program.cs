// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using System;
using static System.Console;

Clear();

int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");

double[,] arr = GenArray(n, m);
PrintArr(arr);

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

// Функция (Метод) для заполнения массива вещественными числами
double[,] GenArray(int row, int column)
{
    int i = 0; int j = 0;
    double[,] arr = new double[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = Math.Round(new Random().Next(0, 101) + new Random().NextDouble(), 2);
            j++;
        }
        i++;
    }
    return arr;
}


// Функция вывода массива в консоль
void PrintArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
          {
            Console.Write(arr[i, j]+ " ");
        }
        Console.WriteLine();
    }
}
 
