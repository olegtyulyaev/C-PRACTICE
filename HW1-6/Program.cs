// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка)
 Console.WriteLine("Введите число :  ");
int N = int.Parse(Console.ReadLine());
    
if (N%2 ==0)
{Console.WriteLine($"число {N} - четное");}
else {Console.WriteLine($"число {N} - нечетное");}