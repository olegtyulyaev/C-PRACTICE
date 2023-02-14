// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным

Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek=int.Parse(Console.ReadLine());
if(numberDayOfWeek<1||numberDayOfWeek>7)
{
    Console.WriteLine("Введен неправильный номер");
    return;
}

if(numberDayOfWeek==6 || numberDayOfWeek==7)
{
    Console.WriteLine("Ура! Это выходной");
}
else 
{
Console.WriteLine("Это будний(");
}