// // Задача 1
// // Задайте двумерный массив. Найдите элементы, у которых оба
// // индекса чётные, и замените эти элементы на их квадраты.
// // Пример
// // 2 3 4 3
// // 4 3 4 1 =>
// // 2 9 5 4
// // Обсудить этапы решения задачи
// // Оформить этапы в виде функций
// // 4 3 4 3
// // 4 3 4 1
// // 2 9 25 4

// int[,] array = new int[3,4];

// void CreateArray()
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i,j]= new Random().Next(0,10);
// }
// }
// }


// void PrintArray()
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// System.Console.Write(array[i,j]+"\t");
// }
// System.Console.WriteLine();
// }
// }

// void ChangeArray()
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// if(i %2==0 && j%2==0)
// {
// array[i,j] = array[i,j] * array[i,j];
// }
// }
// }
// }

// CreateArray();
// PrintArray();
// ChangeArray();
// System.Console.WriteLine();
// PrintArray();







// //Задача 2
// // Задайте двумерный массив. Найдите сумму элементов,
// // находящихся на главной диагонали (с индексами (0,0); (1;1) и
// // т.д.
// // Пример
// // 2 3 4 3
// // 4 3 4 1 => 2 + 3 + 5 = 10
// // 2 9 5 4

// int[,] array = new int[3,4];

// void CreateArray()
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i,j]= new Random().Next(0,10);
// }
// }
// }


// void PrintArray()
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// System.Console.Write(array[i,j]+"\t");
// }
// System.Console.WriteLine();
// }
// }

// int GetSumNum()
// {
// int sum =0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// if(i == j)
// {
// sum += array[i,j];
// }
// }
// }
// return sum;
// }

// CreateArray();
// PrintArray();

// System.Console.WriteLine(GetSumNum());







// //Задача 3
// // Задайте двумерный массив из целых чисел. Сформируйте новый
// // одномерный массив, состоящий из средних арифметических
// // значений по строкам двумерного массива.
// // Пример
// // 2 3 4 3
// // 4 3 4 1 => [3 3 5]
// // 2 9 5 4
// // Обсудить этапы решения задачи
// // Оформить этапы в виде функций

// Console.WriteLine("Ввндите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Ввндите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,columns];
// double [] array2 = new double[rows];

// void CreateArray()
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i,j]= new Random().Next(0,10);
// }
// }
// }


// void PrintArray()
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// System.Console.Write(array[i,j]+"\t");
// }
// System.Console.WriteLine();
// }
// }

// void GetAverageNum()
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// double sum =0;
// for (int j = 0; j < array.GetLength(1); j++)
// {
// sum += array[i,j];
// }
// array2[i] = sum/array.GetLength(1);
// }
// }

// void PrintArray2()
// {
// for (int i = 0; i < array2.Length; i++)
// {
// System.Console.Write(array2[i]+"\t");
// }
// }

// CreateArray();
// PrintArray();
// System.Console.WriteLine();
// GetAverageNum();
// PrintArray2();