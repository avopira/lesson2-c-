// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

//  тип возвращающего значения + Название + ()+ {}

// System.Console.WriteLine("Enter number");
// int sizeArray = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [sizeArray];


// void GetArray()
// {
//      for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }


// int GetCountNumbers()
// {
//     int count=0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] %10==1 &&  array[i] %7==0)  //  && - и    || - или
//         {
//             count = count+1;
//         }
//     }
//     return count;
// }

// GetArray();
// PrintArray();
// int num =GetCountNumbers();
// System.Console.WriteLine("Count = "+num);




// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231


// System.Console.WriteLine("Enter number");
// int sizeArray = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [sizeArray];

// void GetArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }


// int GetNumber()
// {
//     string num="";

//     for (int i = 0; i < array.Length; i++)
//     {
//         num =num+ array[i].ToString();
//     }

//     return Convert.ToInt32(num);
// }


// GetArray();
// PrintArray();
// int num = GetNumber();
// System.Console.WriteLine("Number = "+num);







//Задача 3
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

int [] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
array[i]= new Random().Next(0,100);
System.Console.WriteLine(array[i]+ " ");
}

int count=0;

for (int i = 0; i < array.Length; i++)
{
bool isFind =false;

for (int j = 2; j < Math.Sqrt(array[i]); j++)
{
if(array[i] % j==0)
{
isFind=true;
break;
}
}
if(!isFind)
{
count++;
}
}
System.Console.WriteLine("Кол. = "+ count);