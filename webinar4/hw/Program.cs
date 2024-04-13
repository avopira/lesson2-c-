// Задача 1.
//Напишите программу, которая бесконечно запрашивает целые 
//числа с консоли. Программа завершается при вводе символа 
//‘q’ или при вводе числа, сумма цифр которого чётная.


while (true)
{
Console.Write("Enter number or 'q':");
string i = Console.ReadLine();

    if (i == "q")
    {
        Console.Write("STOP");
        break;
    }

    int num;
    if (int.TryParse(i, out num))
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        if (sum % 2 == 0)
        {
            Console.Write("STOP");
            break;
        }
        else
        {
            Console.Write("please enter correct value. ");

        }
    }
}


// //Задача 2.
// // Задайте массив заполненный случайными трёхзначными 
// // числами. Напишите программу, которая покажет количество 
// // чётных чисел в массиве.

// int [] array = new int [new Random().Next(1,10)];

// void GetArray()
// {
//     for (int i = 0; i <array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
// }

// void PrintArray()
// {
//     for (int i =0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int count = 0;
// int GetEvenNumbers()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 ==0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// GetArray();
// PrintArray();
// int num = GetEvenNumbers();
// Console.WriteLine("Count of even numbers =" + num);



// Задача 3.
// Напишите программу, которая перевернёт одномерный 
// массив (первый элемент станет последним, второй – 
// предпоследним и т.д.)

// int [] array = new int [new Random().Next(2,10)];
// int temp;

// void GetArray()
// {
//     for (int i = 0; i <array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
// }

// Console.Write("original array: ");
// GetArray();

// foreach (int i in array)
// {
//     Console.Write(i + " ");
// }

// for (int i = 0; i < array.Length/2; i++)
// {
//     temp = array[i];
//     array[i] = array[array.Length - i - 1];
//     array[array.Length - i - 1] = temp;
// }

// Console.WriteLine();
// Console.Write("new array: ");
// foreach (int i in array)
// {
//     Console.Write(i + " ");
// }