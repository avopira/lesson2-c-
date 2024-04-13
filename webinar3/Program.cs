// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

// int [] array = new int[8]; 

// System.Console.WriteLine("Enter number");
// int num = Convert.ToInt32(Console.ReadLine());

// string find = "No";

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,10);  
//     System.Console.Write(array[i] + " ");

//     if(num == array[i])
//     {
//         find = "Yes";
//     }
    
// }
// System.Console.WriteLine(find);




// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]


// int sizeArray= 10;
// int [] array = new int[sizeArray]; 

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10,11);  
//     System.Console.Write(array[i] + " ");
// }

// System.Console.WriteLine();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] *-1;  
//     System.Console.Write(array[i] + " ");
// }



// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

// Console.WriteLine("Enter number");
// int sizeArray = Convert.ToInt32(Console.ReadLine());

// int [] array = new int[sizeArray]; 
// int [] array2 = new int[sizeArray/2]; 

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10,11);  
//     System.Console.Write(array[i] + " ");
// }

// System.Console.WriteLine();

// for (int i = 0; i < array2.Length; i++)
// {
//     array2[i] = array[i] * array[array.Length-1-i];  
//     System.Console.Write(array2[i] + " ");
// }


// // Дано натуральное трёхзначное число. Создайте массив, состоящий из
// // цифр этого числа. Младший разряд числа должен располагаться на 0-
// // м индексе массива, старший – на 2-м.
// // Пример
// // 456 => [6 5 4]
// // 781 => [1 8 7]

Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());

int [] array = new int[3];   

for (int i = 0; i < array.Length; i++)
{
    array[i] = num%10;  
    System.Console.Write(array[i] + " ");

    num = num/10;
}



//
// int num = new Random().Next(0,1000000);
// System.Console.WriteLine(num);

// int numCopy = num;
// int countNumber=0;

// while(numCopy>0)
// {
//     numCopy = numCopy/10;
//     countNumber++;
// }

// int [] array = new int[countNumber];   

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = num%10;  
//     System.Console.Write(array[i] + " ");

//     num = num/10;
