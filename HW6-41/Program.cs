// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

    Console.Clear();
    string randomNumbers = ReadDataStr("Введите последовательность чисел через запятую: ");
    int countPosNum = CountPositivNumber(randomNumbers);
    Console.WriteLine("Количество положительных чисел: " + countPosNum);

    // Метод читает данные от пользователя
    string ReadDataStr(string msg)
    {
        Console.WriteLine(msg);
        return Console.ReadLine() ?? "0";
    }

    //Метод считает кол-во положительных элементов
    int CountPositivNumber(string str)
    {
        int count = 0;
        string strWoSp = str.Replace(" ", "");
        string[] strArr = strWoSp.Split(",");
        int[] intArr = new int[strArr.Length];

        for (int i = 0; i < intArr.Length; i++) intArr[i] = int.Parse(strArr[i]);
        for (int i = 0; i < intArr.Length; i++) if (intArr[i] > 0) count++;

        return count;
 }

