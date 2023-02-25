// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
 int num = int.Parse(Console.ReadLine());

static int GetSum (int value)
{
    if (value <10 )
    return value;

    int digit = value % 10;
    int nextValue = value / 10;
    return digit + GetSum(nextValue);
}

Console.WriteLine($"Сумма цифр = {GetSum(num)}");