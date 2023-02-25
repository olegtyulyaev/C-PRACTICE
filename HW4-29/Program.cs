// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//   6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.Write("Введите желаемую длинну массива: ");
Int32 enterNumber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[enterNumber];

for (int i = 0; i < enterNumber; i++)
{
array[i] = new Random().Next(enterNumber+1);
 Console.Write(array[i] + "; ");
}
Console.WriteLine();