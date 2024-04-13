// //Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

//  int CountItemsRange(int[] numbers, int minRange, int maxRange)
//     {
//          //Введите сюда свое решение
//       int count = 0;
//       for (int i = 0; i < numbers.Length; i++)
//       {
//         if (numbers[i] >= minRange && numbers[i] <= maxRange)
//         {
//           count = count + 1;
//         }
//       }
//       return count;
//     }
    
//     void PrintResult(int[] array)
//     {
        
//           //Введите сюда свое решение
//       Console.WriteLine(CountItemsRange(array,10,90));
//     }



//Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива

double FindMin(double[] array)
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
        {
            min = array[i];
        }
    i++;
}
return min;

double FindMax(double[] array)
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    i++;
}
return max;

double result = FindMax() - FindMin();
Console.WriteLine(result);