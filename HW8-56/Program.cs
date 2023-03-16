// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов

using System;
using static System.Console;

Clear();

 int row = ReadData("Количество строк матрицы: ");
 int column = ReadData("Количество столбцов матрицы: ");
 int range = ReadData("Диапазон элементов массива: ");

 
 int[,] arr2D = Gen2DArrayInt(row, column, range);

 Console.WriteLine("Исходный 2D массив: ");
 Print2DArr(arr2D);

 // Поиск строки с наименьшей суммой
 int minSumLine = 0;
 int sumLine = SumLine(arr2D, 0);
 for (int i = 1; i < arr2D.GetLength(0); i++)
 {
     int tempSumLine = SumLine(arr2D, i);
     if (sumLine > tempSumLine)
     {
         sumLine = tempSumLine;
         minSumLine = i;
     }
 }
 minSumLine = minSumLine + 1;

 Console.WriteLine();
 Console.WriteLine("Строка с наименьшей суммой равна: " + minSumLine);
 Console.WriteLine("Наименьшая сумма равна: " + sumLine);


 // Функция ввода данных с консоли
 int ReadData(string msg)
 {
     Console.Write(msg);
     return int.Parse(Console.ReadLine() ?? "0");
 }

 // Функция для заполнения 2D массива целыми числами
 int[,] Gen2DArrayInt(int row, int column, int range)
 {
     int i = 0; int j = 0;
     int[,] arr = new int[row, column];
     while (i < row)
     {
         j = 0;
         while (j < column)
         {
             arr[i, j] = new Random().Next(0, range);
             j++;
         }
         i++;
     }
     return arr;
 }

 // Функция вывода 2D  массива в консоль
 void Print2DArr(int[,] arr)
 {
     for (int i = 0; i < arr.GetLength(0); i++)
     {
         for (int j = 0; j < arr.GetLength(1); j++)
         {
             Console.Write(arr[i, j] + " ");
         }
         Console.WriteLine("");
     }
 }

 // Метод считает сумму элементов строки массива
 int SumLine(int[,] array, int i)
 {
     int sumLine = array[i, 0];
     for (int j = 1; j < array.GetLength(1); j++)
     {
         sumLine += array[i, j];
     }
     return sumLine;
 }