// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введи число: ");
  
int RandomDigit = int.Parse(Console.ReadLine());
string RandomText = Convert.ToString(RandomDigit);
if (RandomText.Length > 2){
 Console.WriteLine("третья цифра -> " + RandomText[2]);
}
else {
 Console.WriteLine("-> третьей цифры нет");
}
