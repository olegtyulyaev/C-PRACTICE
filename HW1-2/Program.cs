// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите первое число для сравнения: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число для сравнения: ");
int b = int.Parse(Console.ReadLine());

if(a>b)
{
    Console.WriteLine($"Первое число {a} максимальное в паре");
}else
{
    Console.WriteLine($"Второе число {b} максимальное в паре");
}