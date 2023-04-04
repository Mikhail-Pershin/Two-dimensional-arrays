// // // // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // // // m = 3, n = 4.

// // // // 0,5 7 -2 -0,2

// // // // 1 -3,3 8 -9,9

// // // // 8 7,8 -7,1 9


// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = GetArrayDouble(rows, columns, 0, 10);
// Console.WriteLine($"Наш массив:");
// PrintArray(array);
// Console.WriteLine();

// // ----------------Заполнение массива-------------------
// double[,] GetArrayDouble(int m, int n, int minValue, int maxValue)
// {
//   double[,] res = new double[m, n];

//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       res[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(maxValue - minValue), 2);
//     }
//   }
//   return res;
// }

// // -----------------Вывод массива-----------------
// void PrintArray(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }


// Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), 
// проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, 
// что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// i = 1, j = 3 -> Такой элемент есть: 3
// i = 4, j = 2 -> такого элемента в массиве нет


Console.Write("Введите первое число(строка): ");
int rowsNumber = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число(столбец): ");
int columnsNumber = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(3, 4, 0, 10);
Console.WriteLine($"Наш массив:");
PrintArray(array);
// Console.WriteLine();

if (rowsNumber > array.GetLength(0) || columnsNumber > array.GetLength(1))
{
  Console.WriteLine("Такого элемента в массиве нет");
}
else
{
  Console.WriteLine($"строка {rowsNumber}, столбец {columnsNumber} -> такой элемент есть: {array[rowsNumber - 1, columnsNumber - 1]}");
}

// ----------------Заполнение массива-----------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
  int[,] res = new int[m, n];

  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      res[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return res;
}

// -----------------Вывод массива-----------------
void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}
