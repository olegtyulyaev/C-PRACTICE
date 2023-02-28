// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] testArr = GenArray(5,100,999);
 PrintArr(testArr);
int count = CountElem(testArr);
PrintData("Количество четных элементов: "+count);


  // Метод вывода данных в консоль
  void PrintData(string res)
  {
     Console.WriteLine(res);
 }

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

 // Метод печати  массива в консоль
 void PrintArr(int[] arr)
 
   {   for (int i = 0; i < arr.Length - 1; i++)
     {
          Console.Write(arr[i] + ", ");
      }
     Console.WriteLine(arr[arr.Length - 1]);
      }

 // Метод подсчета элементов массива по заданному условию
  int CountElem(int[] arr)
  {
      int res = 0;
      for (int i = 0; i < arr.Length; i++)
      {
          if (Test(arr[i]))
          {
              res++;
          }
      }
      return res;
  }

  // Метод тест элемента массива на четность
  bool Test(int n)
  {
      return (n % 2 == 0);
  }