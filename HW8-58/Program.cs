// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


using System;
using static System.Console;

Clear();

 int row1 = ReadData("Количество строк первой матрицы: ");
 int colFirstRowSec = ReadData("Количество строк первой и столбцов второй матрицы: ");
 int column2 = ReadData("Количество столбцов второй матрицы: ");
 int range = ReadData("Диапазон элементов массива от 0: ");
 Console.WriteLine();


 int[,] arr2DFirst = Gen2DArrayInt(row1, colFirstRowSec, range);
 int[,] arr2DSecond = Gen2DArrayInt(colFirstRowSec, column2, range);

 Console.WriteLine("Первый 2D массив: ");
 Print2DArr(arr2DFirst);
 Console.WriteLine();
 Console.WriteLine("Второй 2D массив: ");
 Print2DArr(arr2DSecond);

 // Вычисление произведения двух матриц
 int[,] res2DArr = new int[row1, column2];
 Mylti2DArr(arr2DFirst, arr2DSecond, res2DArr);

 Console.WriteLine();
 Console.WriteLine("произведение 2х матриц: ");
 Print2DArr(res2DArr);

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

 // Метод вычисляет произведение двух массивов (матриц)
 void Mylti2DArr(int[,] arr1, int[,] arr2, int[,] resArr)
 {

     for (int i = 0; i < resArr.GetLength(0); i++)
     {
         for (int j = 0; j < resArr.GetLength(1); j++)
         {
             int sum = 0;
             for (int k = 0; k < arr1.GetLength(1); k++)
             {
                 sum += arr1[i, k] * arr2[k, j];
             }
             resArr[i, j] = sum;
         }
     }
 }
