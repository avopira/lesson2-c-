// // Задача 1. 
// // Напишите программу, которая на вход принимает позиции 
// // элемента в двумерном массиве, и возвращает значение 
// // этого элемента или же указание, что такого элемента 
// // нет: "Позиция по рядам выходит за пределы массива"
// // или
// // "Позиция по колонкам выходит за пределы массива"

// // Позиции в массиве считать от единицы.

// int [,] array = new int [,]{
//     {1,2,3,4},
//     {5,6,7,8},
//     {9,10,11,12}
// };

// int x =2;
// int y =2;

// int FindElementByPosition (int [,] array, int x, int y)

// {
//     int value = array[x-1, y-1];
//     return value;
// }

// FindElementByPosition(array, x,y);

// bool ValidatePosition(int[,] array, int x, int y)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);
//     bool position = true; 
//     if (x < 0 || x > rows || y < 0 || y > columns)
//     {
//         position = false;  
//     }
//     return position;
// }

// void PrintResult(int[,] numbers, int x, int y)
// {
//     if (ValidatePosition(numbers, 2, 2) ==true)
//         {
//             Console.WriteLine(FindElementByPosition(numbers, x, y));
//         }
//         else
//         {
//             Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//         }
// }
// PrintResult(array,2,2);


// // Задача 2
// // Задайте двумерный массив. Напишите программу, которая поменяет 
// // местами первую и последнюю строку массива.

// // Начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// }; 

// void PrintArray(int [,] array) 
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] SwapRows(int[,] array) // - code corrected by AI
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int temp = array[0, j];
//         array[0, j] = array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = temp;
//     }
//     return array;
// }

// PrintArray(numbers);
// SwapRows(numbers);
// PrintArray(numbers);




// // Задача 3
// // Задайте прямоугольный двумерный массив. Напишите программу, 
// // которая будет находить строку с наименьшей суммой элементов.

// // Начальные условия
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };

// int[] SumRows(int[,] array)
// {
//     int [] array2 = new int [array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i,j];
//         }
//         array2[i] = sum;
//     }
//     return array2;
// }

// int MinIndex(int[] array)
// {
//         int minIndex = 0; 
//         int min = array[minIndex];      
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i] < min)
//             {
//                 min = array[i];
//                 minIndex = i;
//             }
//         }
//     return minIndex;
// }

// int [] sums = SumRows(numbers);
// Console.Write(MinIndex(sums));



//Задача 4
// Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

int [,] array1 = new int [3,3]{
    {4,5,2},
    {6,1,85},
    {3,5,2}
};

void PrintArray(int [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int [] GetMinIndices(int [,] array)
{
    int min = array[0,0];
    int [] MinIndices = {0,0};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < min)
            {
                min = array[i,j];
                MinIndices[0] = i;
                MinIndices[1] = j;
            }
        }
    }
    return MinIndices;
}


PrintArray(array1);
int [] array3 = GetMinIndices(array1);

int [,] DeleteMinElementRowColumn(int [,] array, int RowtoRemove, int ColumnToRemove)
{
    int rowNum = array.GetLength(0)-1;
    int columnNum = array.GetLength(1)-1;
    int [,] array2 = new int [rowNum, columnNum];
    for (int i = 0, array2row = 0; i < array.GetLength(0); i++)
    {
        if (i == RowtoRemove)
        {
            continue;
        }    
        for (int j = 0, array2column = 0; j < array.GetLength(1); j++)
            {
                if (j == ColumnToRemove)
                {
                    continue;
                }
                array2[array2row, array2column] = array[i,j];
                array2column++;
            }
        array2row++;
    }
    return array2;
}  

int [,] result = DeleteMinElementRowColumn(array1, array3[0], array3[1]);
Console.WriteLine();
PrintArray(result);
