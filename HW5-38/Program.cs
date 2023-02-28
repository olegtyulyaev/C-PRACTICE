// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

    Console.Clear();
    int[] testArr = GenArray(5, 1, 10);
    PrintArr(testArr);
    Console.WriteLine("Разница между мах и мин составляет:");
    PrintData(MaxMin(testArr));

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
    void PrintData(int res)
    {
        Console.WriteLine(res);
    }

    // Метод рассчета разницы м/д Max и Min элементами массива
    int MaxMin(int[] arr)
    {
    int max = int.MinValue;
    int min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
        return max - min;
    }


