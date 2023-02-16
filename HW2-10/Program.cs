// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введи трёхзначное число: ");
int Number =  int.Parse(Console.ReadLine());
string stringNumber = Convert.ToString(Number);
Console.WriteLine("вторая цифра введенного числа - "+stringNumber[1]);

