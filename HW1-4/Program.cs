// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Clear();
Console.Write("Введите число 1:  ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2:  ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число 3:  ");
int c = int.Parse(Console.ReadLine());
if (a>b && a>c)
{
Console.WriteLine($"{a} -> наибольшее из 3х введенных чисел");
} 
else if (b > c)
{
Console.WriteLine($"{b} -> наибольшее из 3х введенных чисел");
}
else
{
Console.WriteLine($"{c} -> наибольшее из 3х введенных чисел");
}
