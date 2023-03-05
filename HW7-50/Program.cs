// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

Write("Введите искомое число ");
int findeNum =int.Parse(ReadLine());



int[,] array = GetArray(rows, columns, 0, 10);
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
// Функция (Метод) поиска существования элемента в массиве и вывод результата в консоль
void SerchElemAndPrint(int[,] array, int serchElem)
{
    bool elemSerch = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (serchElem == array[i, j])
            {
                elemSerch = true;
                Console.ForegroundColor = System.ConsoleColor.Green;
            }
            Console.Write(array[i, j] + "  ");
            Console.ForegroundColor = System.ConsoleColor.White;
        }
        Console.WriteLine();
    }
    if (elemSerch == false)
    {
        Console.WriteLine("Элемент " + serchElem + " не найден");
    }
    Console.ForegroundColor = System.ConsoleColor.White;
}

Console.WriteLine();
SerchElemAndPrint(array, findeNum);

