// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] testArr = GenArray(7,1,100);
PrintArr(testArr);
int totalsum = SumNec(testArr);
PrintData("Сумма нечетных элементов массива: " + totalsum);

// Метод генерации массива
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

// Метод печати массива в консоль
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Метод вывода значения в консоль
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод считает сумму элементов массива с нечетными индексами
int SumNec(int [] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        res += arr[i];
    }
    return res;
}